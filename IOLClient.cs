using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BOTArbitradorPUTs
{
    public class IOLClient : IDisposable
    {
        private const string BaseUrl = "https://api.invertironline.com";

        private readonly HttpClient _http;
        private string _accessToken;
        private string _refreshToken;
        private DateTime _tokenExpiry;

        public bool EstaAutenticado => !string.IsNullOrEmpty(_accessToken) && DateTime.Now < _tokenExpiry;

        public IOLClient()
        {
            _http = new HttpClient { BaseAddress = new Uri(BaseUrl) };
        }

        /// <summary>
        /// Autentica contra la API de IOL y obtiene el Bearer token.
        /// </summary>
        public async Task<bool> LoginAsync(string usuario, string clave)
        {
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", usuario),
                new KeyValuePair<string, string>("password", clave),
                new KeyValuePair<string, string>("grant_type", "password"),
            });

            var response = await _http.PostAsync("/token", content);
            if (!response.IsSuccessStatusCode)
                return false;

            var json = JObject.Parse(await response.Content.ReadAsStringAsync());
            _accessToken = json[".accessToken"]?.ToString() ?? json["access_token"]?.ToString();
            _refreshToken = json[".refreshToken"]?.ToString() ?? json["refresh_token"]?.ToString();

            var expiresIn = json["expires_in"]?.Value<int>() ?? 900;
            _tokenExpiry = DateTime.Now.AddSeconds(expiresIn - 60);

            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);
            return true;
        }

        /// <summary>
        /// Renueva el token usando el refresh_token.
        /// </summary>
        public async Task<bool> RefreshTokenAsync()
        {
            if (string.IsNullOrEmpty(_refreshToken))
                return false;

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("refresh_token", _refreshToken),
                new KeyValuePair<string, string>("grant_type", "refresh_token"),
            });

            var response = await _http.PostAsync("/token", content);
            if (!response.IsSuccessStatusCode)
                return false;

            var json = JObject.Parse(await response.Content.ReadAsStringAsync());
            _accessToken = json[".accessToken"]?.ToString() ?? json["access_token"]?.ToString();
            _refreshToken = json[".refreshToken"]?.ToString() ?? json["refresh_token"]?.ToString();

            var expiresIn = json["expires_in"]?.Value<int>() ?? 900;
            _tokenExpiry = DateTime.Now.AddSeconds(expiresIn - 60);

            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);
            return true;
        }

        /// <summary>
        /// Asegura que el token esté vigente, refrescando si es necesario.
        /// </summary>
        private async Task AsegurarTokenAsync()
        {
            if (!EstaAutenticado && !string.IsNullOrEmpty(_refreshToken))
                await RefreshTokenAsync();
        }

        /// <summary>
        /// Envía una orden de compra a IOL.
        /// POST /api/v2/operar/Comprar
        /// </summary>
        /// <param name="mercado">Mercado (ej: "bCBA")</param>
        /// <param name="simbolo">Símbolo del instrumento (ej: "GGAL" o "GFGV75029A")</param>
        /// <param name="cantidad">Cantidad (acciones u opciones)</param>
        /// <param name="precio">Precio límite</param>
        /// <param name="plazo">Plazo: "t0" (CI) o "t1" (24hs)</param>
        /// <param name="validez">Fecha de validez de la orden</param>
        /// <returns>Resultado con número de orden o error</returns>
        public async Task<OrdenResultado> ComprarAsync(string mercado, string simbolo, int cantidad, decimal precio, string plazo, DateTime validez)
        {
            await AsegurarTokenAsync();

            var body = new
            {
                mercado,
                simbolo,
                cantidad,
                precio,
                plazo,
                validez = validez.ToString("yyyy-MM-ddTHH:mm:ss")
            };

            var json = JsonConvert.SerializeObject(body);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = await _http.PostAsync("/api/v2/operar/Comprar", content);
            var responseBody = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var result = JObject.Parse(responseBody);
                return new OrdenResultado
                {
                    Exitosa = true,
                    NumeroOrden = result["numeroOperacion"]?.Value<long>() ?? 0,
                    Mensaje = $"Orden OK #{result["numeroOperacion"]}"
                };
            }
            else
            {
                return new OrdenResultado
                {
                    Exitosa = false,
                    NumeroOrden = 0,
                    Mensaje = $"Error {response.StatusCode}: {responseBody}"
                };
            }
        }

        /// <summary>
        /// Obtiene la liquidez (saldo disponible) para el plazo indicado desde el estado de cuenta.
        /// GET /api/v2/estadocuenta
        /// </summary>
        /// <param name="plazo">Plazo: "t0" (CI), "t1" (24hs) o "t2" (48hs)</param>
        /// <returns>Saldo disponible en pesos para el plazo, o null si hubo error</returns>
        public async Task<decimal?> ObtenerLiquidezAsync(string plazo = "t1")
        {
            await AsegurarTokenAsync();

            var response = await _http.GetAsync("/api/v2/estadocuenta");
            if (!response.IsSuccessStatusCode)
                return null;

            var responseBody = await response.Content.ReadAsStringAsync();
            var json = JObject.Parse(responseBody);

            // La respuesta tiene "cuentas" con array de cuentas.
            // Cada cuenta tiene "tipo" ("inversion_Argentina_Pesos", etc.) y "saldos" array.
            // Cada saldo tiene "liquidacion" ("inmediata", "hrs24", "hrs48") y "disponible".
            var cuentas = json["cuentas"] as JArray;
            if (cuentas == null)
                return null;

            // Mapeo de plazo a liquidación
            var liquidacion = plazo switch
            {
                "t0" => "inmediata",
                "t1" => "hrs24",
                "t2" => "hrs48",
                _ => "hrs24"
            };

            foreach (var cuenta in cuentas)
            {
                var tipo = cuenta["tipo"]?.ToString() ?? "";
                if (!tipo.Contains("Pesos", StringComparison.OrdinalIgnoreCase))
                    continue;

                var saldos = cuenta["saldos"] as JArray;
                if (saldos == null)
                    continue;

                foreach (var saldo in saldos)
                {
                    if (string.Equals(saldo["liquidacion"]?.ToString(), liquidacion, StringComparison.OrdinalIgnoreCase))
                    {
                        return saldo["disponibleOperar"]?.Value<decimal>() ?? 0m;
                    }
                }
            }

            return null;
        }

        public void Dispose()
        {
            _http?.Dispose();
        }
    }

    public class OrdenResultado
    {
        public bool Exitosa { get; set; }
        public long NumeroOrden { get; set; }
        public string Mensaje { get; set; }
    }
}
