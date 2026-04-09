using System;
using System.Configuration;
using Primary;
using Primary.Data;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;


namespace BOTArbitradorPUTs
{
    public partial class frmMain : Form
    {
        /*
        const string sURL = "https://api.invertironline.com";
        const string SURLOper = "https://www.invertironline.com";
        */
        const string sURLVETA = "https://api.veta.xoms.com.ar";

        string tokenVETA;
        string bearer;
        string refresh;
        double umbral;
        double timeOffset;
        string[] tickers;

        private IOLClient iolClient;
        private bool operacionEnCurso = false;
        private readonly HashSet<string> putsOperados = new();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "BOT Arbitrador de PUTs bajo la par estilo Juancho, DeltaVega & Cabras - Copyright 2022 Tinchex Capital";
            DoubleBuffered = true;
            CheckForIllegalCrossThreadCalls = false;

            var configuracion = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            try
            {
                txtUsuarioIOL.Text = configuracion.GetSection("MiConfiguracion:UserIOL").Value;
                txtClaveIOL.Text = configuracion.GetSection("MiConfiguracion:ClaveIOL").Value;
                txtUsuarioVETA.Text = configuracion.GetSection("MiConfiguracion:UserVETA").Value;
                txtClaveVETA.Text = configuracion.GetSection("MiConfiguracion:ClaveVETA").Value;
                tickers = configuracion.GetSection("MiConfiguracion:TickersPUT").Get<string[]>() ?? Array.Empty<string>();
            }
            catch (Exception ex)
            {

            }

            grdDatos.Rows.Clear();
            grdDatos.Columns.Add("Ticker", "Ticker");
            grdDatos.Columns[0].Width = 320;
            grdDatos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdDatos.Columns.Add("Stamp", "Stamp");
            grdDatos.Columns[1].Width = 90;
            grdDatos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdDatos.Columns.Add("Bid", "Bid");
            grdDatos.Columns[2].Width = 70;
            grdDatos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDatos.Columns.Add("Last", "Last");
            grdDatos.Columns[3].Width = 70;
            grdDatos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDatos.Columns.Add("Ask", "Ask");
            grdDatos.Columns[4].Width = 70;
            grdDatos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDatos.Columns.Add("AskSize", "Ask Size");
            grdDatos.Columns[5].Width = 70;
            grdDatos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDatos.Columns.Add("CostCpra", "Costo Compra");
            grdDatos.Columns[6].Width = 90;
            grdDatos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDatos.Columns.Add("Armar", "Armar");
            grdDatos.Columns[7].Width = 90;
            grdDatos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDatos.Columns.Add("Ejercer", "Ejercer");
            grdDatos.Columns[8].Width = 90;
            grdDatos.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDatos.Columns.Add("Ratio", "Ratio");
            grdDatos.Columns[9].Width = 60;
            grdDatos.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDatos.Columns.Add("Neto", "Neto");
            grdDatos.Columns[10].Width = 90;
            grdDatos.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDatos.RowHeadersWidth = 4;

            cmbUmbral.Text = "0,2";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Inicio();
        }
        public async Task Inicio()
        {
            // Login IOL
            iolClient = new IOLClient();
            var loginIOL = await iolClient.LoginAsync(txtUsuarioIOL.Text, txtClaveIOL.Text);
            if (loginIOL)
                ToLog("IOL: Login exitoso");
            else
                ToLog("IOL: Error en login");

            // Login VETA
            var api = new Api(new Uri(sURLVETA));
            await api.Login(txtUsuarioVETA.Text, txtClaveVETA.Text);

            var allInstruments = await api.GetAllInstruments();
            var entries = new[] { Entry.Last, Entry.Bids, Entry.Offers };


			var instrumentos = allInstruments.Where(c => tickers.Contains(c.Symbol));

            /*
            var instrumentos = allInstruments.Where(c => c.Symbol.StartsWith("MERV - XMEV - GGAL"))
                .Concat(allInstruments.Where(c => c.Symbol.StartsWith("MERV - XMEV - GFG")));
            */

            grdDatos.Rows.Add("MERV - XMEV - GGAL - CI");
            grdDatos.Rows[grdDatos.Rows.Count - 1].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdDatos.Rows.Add("MERV - XMEV - GGAL - 24hs");
            grdDatos.Rows[grdDatos.Rows.Count - 1].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            foreach (var instrument in instrumentos.Where(i => i.Symbol.EndsWith("24hs")).OrderBy(i => i.Symbol))
            {
                grdDatos.Rows.Add(instrument.Symbol);
                grdDatos.Rows[grdDatos.Rows.Count - 1].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                grdDatos.Rows[grdDatos.Rows.Count - 1].Cells[0].Style.WrapMode=DataGridViewTriState.True;
            }

            var socket = api.CreateMarketDataSocket(instrumentos, entries, 1, 1);
            socket.OnData = OnMarketData;

            var socketTask = await socket.Start();

            socketTask.Wait(1000);
            await socketTask;
        }

        private async void OnMarketData(Api api, MarketData marketData)
        {
            string ticker = marketData.Instrument.Symbol;

            var bid = default(decimal);
            var offer = default(decimal);
            var bidSize = default(decimal);
            var offerSize = default(decimal);
            var last = default(decimal);
            var costo = default(decimal);
            var armar = default(decimal);
            var offerCI = default(decimal);
            var offer48 = default(decimal);
            var ejercer = default(decimal);
            var ratio = default(decimal);
            var neto = default(decimal);
            var strike = default(decimal);

            DateTime dt;

            if (ticker.IndexOf("GFGV") > 0 || ticker.IndexOf("GGAL") > 0)
            {
                if (marketData.Data.Last == null)
                { last = 0; }
                else
                { last = marketData.Data.Last.Price; }

                if (marketData.Data.Bids != null)
                {
                    foreach (var trade in marketData.Data.Bids)
                    {
                        bid = trade.Price;
                        bidSize = trade.Size;
                    }
                }

                if (marketData.Data.Offers != null)
                {
                    foreach (var trade in marketData.Data.Offers)
                    {
                        offer = trade.Price;
                        offerSize = trade.Size;
                    }
                }

                dt = DateTimeOffset.FromUnixTimeMilliseconds(marketData.Timestamp).DateTime.AddHours(-3);

                ToLog($"{ticker}");

                //Actualización de grilla

                for (int i = 0; i < grdDatos.Rows.Count; i++)
                {
                    var row = grdDatos.Rows[i];
                    if (ticker == row.Cells[0].Value.ToString())
                    {
                        row.Cells[1].Value = dt.ToString("T");
                        row.Cells[2].Value = Math.Round(bid,2);
                        row.Cells[3].Value = Math.Round(last,2);
                        row.Cells[4].Value = Math.Round(offer,2);
                        row.Cells[5].Value = Math.Round(offerSize, 2);

                        if (ticker.Contains("GGAL"))
                        {
                            costo = offer / 100 * (decimal)0.22;
                            if (ticker.Contains("CI"))
                            {
                                offerCI = (decimal)grdDatos.Rows[0].Cells[4].Value;
                            }
                            if (ticker.Contains("24hs"))
                            {
                                offer48 = (decimal)grdDatos.Rows[1].Cells[4].Value;
                            }
                        }
                        else
                        {
                            costo = offer / 100 * (decimal)0.37;
                            strike = decimal.Parse(row.Cells[0].Value.ToString().Substring(18, 4)) / 1;
                            //strike = decimal.Parse(row.Cells[0].Value.ToString().Substring(18, 5)) / 10;
                            //strike = decimal.Parse(row.Cells[0].Value.ToString().Substring(18, 3)) / 1;
                            ejercer = Math.Round(strike * (decimal)1.0022, 2);
                            row.Cells[8].Value = Math.Round(ejercer, 2);
                        }

                        row.Cells[6].Value = Math.Round(costo + offer, 2);

                        //CI o 48hs
                        if (grdDatos.Rows[1].Cells[6].Value != null)
                        {
                            armar = (decimal)row.Cells[6].Value + (decimal)grdDatos.Rows[1].Cells[6].Value;
                        }
                        row.Cells[7].Value = Math.Round(armar, 2);
                        if (armar == 0)
                        {
                            ratio = 0;
                        }
                        else
                        {
                            ratio = Math.Round(((ejercer / armar) - 1) * 100,2);
                        }
                        row.Cells[9].Value = ratio;
                        neto = Math.Round(ejercer - armar, 2);
                        row.Cells[10].Value = neto;
                        if (ratio>0)
                        {
                            row.Cells[9].Style.ForeColor = Color.LightGreen;
                            row.Cells[9].Style.Font = new Font(grdDatos.Font, FontStyle.Bold);
                        }
                        else
                        { 
                            row.Cells[9].Style.ForeColor = Color.Red;
                            row.Cells[9].Style.Font = new Font(grdDatos.Font, FontStyle.Regular);
                        }

                    }
                }

                // Si llegó un dato de GGAL, recalcular todos los PUTs
                if (ticker.Contains("GGAL"))
                {
                    RecalcularPUTs();
                }

                // Evaluar arbitraje para PUTs
                if (ticker.Contains("GFGV") && chkAuto.Checked && ratio > 0)
                {
                    var umbralConfig = decimal.Parse(cmbUmbral.Text);
                    if (ratio >= umbralConfig && offerSize > 0)
                    {
                        await EjecutarArbitraje(ticker, (int)offerSize, offer, ratio);
                    }
                }

                try
                {

                }
                catch (Exception ex)
                {
                    ToLog("error: " + ex.Message);
                }
            }
            Application.DoEvents();
        }
        private async void RecalcularPUTs()
        {
            // Recalcular todos los PUTs cuando cambia el valor de GGAL
            for (int i = 2; i < grdDatos.Rows.Count; i++)
            {
                var row = grdDatos.Rows[i];
                var tickerRow = row.Cells[0].Value?.ToString();

                if (tickerRow != null && tickerRow.Contains("GFGV"))
                {
                    if (row.Cells[4].Value != null && row.Cells[6].Value != null && grdDatos.Rows[1].Cells[6].Value != null)
                    {
                        var costoCompra = (decimal)row.Cells[6].Value;
                        var costoGGAL = (decimal)grdDatos.Rows[1].Cells[6].Value;
                        var armar = costoCompra + costoGGAL;
                        row.Cells[7].Value = Math.Round(armar, 2);

                        if (row.Cells[8].Value != null)
                        {
                            var ejercer = Math.Round((decimal)row.Cells[8].Value, 2);
                            decimal ratio;
                            if (armar == 0)
                            {
                                ratio = 0;
                            }
                            else
                            {
                                ratio = Math.Round(((ejercer / armar) - 1) * 100, 2);
                            }
                            row.Cells[9].Value = ratio;
                            var neto = Math.Round(ejercer - armar, 2);
                            row.Cells[10].Value = neto;

                            if (ratio > 0)
                            {
                                row.Cells[9].Style.ForeColor = Color.LightGreen;
                                row.Cells[9].Style.Font = new Font(grdDatos.Font, FontStyle.Bold);
                            }
                            else
                            {
                                row.Cells[9].Style.ForeColor = Color.Red;
                                row.Cells[9].Style.Font = new Font(grdDatos.Font, FontStyle.Regular);
                            }

                            // Evaluar arbitraje al recalcular desde GGAL
                            if (chkAuto.Checked && ratio > 0 && row.Cells[5].Value != null)
                            {
                                var umbralConfig = decimal.Parse(cmbUmbral.Text);
                                var offerSize = (decimal)row.Cells[5].Value;
                                var offerPut = (decimal)row.Cells[4].Value;
                                if (ratio >= umbralConfig && offerSize > 0)
                                {
                                    await EjecutarArbitraje(tickerRow, (int)offerSize, offerPut, ratio);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Ejecuta el arbitraje: compra PUTs + compra GGAL 24hs en paralelo.
        /// Por cada contrato de PUT se compran 100 acciones GGAL.
        /// </summary>
        private async Task EjecutarArbitraje(string tickerPut, int cantidadContratos, decimal precioPut, decimal ratio)
        {
            if (operacionEnCurso) return;
            if (putsOperados.Contains(tickerPut)) return;
            if (iolClient == null || !iolClient.EstaAutenticado)
            {
                ToLog("IOL: No autenticado, no se puede operar");
                return;
            }

            operacionEnCurso = true;
            putsOperados.Add(tickerPut);

            try
            {
                // Extraer símbolo corto del PUT (ej: "MERV - XMEV - GFGV75029A - 24hs" -> "GFGV75029A")
                var partes = tickerPut.Split(" - ");
                var simboloPut = partes.Length >= 3 ? partes[2].Trim() : tickerPut;

                int cantidadAcciones = cantidadContratos * 100;
                var precioGGAL = grdDatos.Rows[1].Cells[4].Value != null ? (decimal)grdDatos.Rows[1].Cells[4].Value : 0m;

                if (precioGGAL == 0)
                {
                    ToLog($"ARBITRAJE CANCELADO: Sin precio de GGAL");
                    operacionEnCurso = false;
                    return;
                }

                var validez = DateTime.Now.Date;

                ToLog($">>> ARBITRAJE: {simboloPut} x{cantidadContratos} @ {precioPut} + GGAL x{cantidadAcciones} @ {precioGGAL} (ratio {ratio}%)");

                // Enviar ambas órdenes en paralelo
                var taskPut = iolClient.ComprarAsync("bCBA", simboloPut, cantidadContratos, precioPut, "t1", validez);
                var taskGGAL = iolClient.ComprarAsync("bCBA", "GGAL", cantidadAcciones, precioGGAL, "t1", validez);

                var resultados = await Task.WhenAll(taskPut, taskGGAL);

                var resPut = resultados[0];
                var resGGAL = resultados[1];

                ToLog($"  PUT  {simboloPut}: {resPut.Mensaje}");
                ToLog($"  GGAL x{cantidadAcciones}: {resGGAL.Mensaje}");

                if (resPut.Exitosa && resGGAL.Exitosa)
                    ToLog($"  >>> ARBITRAJE ARMADO OK");
                else
                    ToLog($"  >>> ATENCION: Revisar órdenes manualmente");
            }
            catch (Exception ex)
            {
                ToLog($"ARBITRAJE ERROR: {ex.Message}");
            }
            finally
            {
                operacionEnCurso = false;
            }
        }

        private void ToLog(string s)
        {
            lbLog.Items.Add(DateTime.Now.ToString("T") + ": " + s);
            lbLog.SelectedIndex = lbLog.Items.Count - 1;
        }
        private static DateTime Ahora()
        {
            return (DateTime.Now);
        }
    }
    class Arbitraje
    {
        public string Ticker { get; set; }
        public string Stamp { get; set; }
        public decimal Bid { get; set; }
        public decimal Last { get; set; }
        public decimal Ask { get; set; }
        public decimal AskSize { get; set; }
        public decimal CostCpra 
        {
            get
            {   
                return Ask / 100 * 0.37m;
            }
        }

    }
    class Spot
    {
        public string Ticker { get; set; }
        public string Stamp { get; set; }
        public decimal Bid { get; set; }
        public decimal Last { get; set; }
        public decimal Ask { get; set; }
        public decimal AskSize { get; set; }
        public decimal CostCpra
        {
            get
            {
                return Ask / 100 * 0.22m;
            }
        }
    }
    class Arbitrador
    {
        public Spot spot { get; set; }
        public List<Arbitraje> arbitrajes { get; set; }
    }
}