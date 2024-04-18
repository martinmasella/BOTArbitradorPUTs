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

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "BOT Arbitrador de PUTs bajo la par estilo Cuttela - Copyright 2022 Tinchex Capital";
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
            }
            catch (Exception ex)
            {

            }

            grdDatos.Rows.Clear();
            grdDatos.Columns.Add("Ticker", "Ticker");
            grdDatos.Columns[0].Width = 160;
            grdDatos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grdDatos.Columns.Add("Stamp", "Stamp");
            grdDatos.Columns[1].Width = 50;
            grdDatos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdDatos.Columns.Add("Bid", "Bid");
            grdDatos.Columns[2].Width = 40;
            grdDatos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDatos.Columns.Add("Last", "Last");
            grdDatos.Columns[3].Width = 50;
            grdDatos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDatos.Columns.Add("Ask", "Ask");
            grdDatos.Columns[4].Width = 50;
            grdDatos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDatos.Columns.Add("AskSize", "Ask Size");
            grdDatos.Columns[5].Width = 30;
            grdDatos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDatos.Columns.Add("CostCpra", "Costo Compra");
            grdDatos.Columns[6].Width = 50;
            grdDatos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDatos.Columns.Add("Armar", "Armar");
            grdDatos.Columns[7].Width = 50;
            grdDatos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDatos.Columns.Add("Ejercer", "Ejercer");
            grdDatos.Columns[8].Width = 50;
            grdDatos.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDatos.Columns.Add("Ratio", "Ratio");
            grdDatos.Columns[9].Width = 40;
            grdDatos.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDatos.Columns.Add("Neto", "Neto");
            grdDatos.Columns[10].Width = 40;
            grdDatos.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDatos.RowHeadersWidth = 4;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Inicio();
        }
        public async Task Inicio()
        {
            var api = new Api(new Uri(sURLVETA));
            await api.Login(txtUsuarioVETA.Text, txtClaveVETA.Text);

            var allInstruments = await api.GetAllInstruments();
            var entries = new[] { Entry.Last, Entry.Bids, Entry.Offers };

            
            tickers = new[] {"MERV - XMEV - GGAL - 48hs",
                "MERV - XMEV - GGAL - CI",
                "MERV - XMEV - GFGV2900JU - 24hs",
                "MERV - XMEV - GFGV3000JU - 24hs",
                "MERV - XMEV - GFGV3150JU - 24hs",
                "MERV - XMEV - GFGV2300JU - 24hs",
                "MERV - XMEV - GFGV3450JU - 24hs",
                "MERV - XMEV - GFGV3600JU - 24hs",
                "MERV - XMEV - GFGV3750JU - 24hs"};
            var instrumentos = allInstruments.Where(c => tickers.Contains(c.Symbol));

            /*
            var instrumentos = allInstruments.Where(c => c.Symbol.StartsWith("MERV - XMEV - GGAL"))
                .Concat(allInstruments.Where(c => c.Symbol.StartsWith("MERV - XMEV - GFG")));
            */

            grdDatos.Rows.Add("MERV - XMEV - GGAL - CI");
            grdDatos.Rows.Add("MERV - XMEV - GGAL - 48hs");

            foreach (var instrument in instrumentos.Where(i => i.Symbol.EndsWith("24hs")).OrderBy(i => i.Symbol))
            {
                grdDatos.Rows.Add(instrument.Symbol);
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
                        row.Cells[5].Value = offerSize;

                        if (ticker.Contains("GGAL"))
                        {
                            costo = offer / 100 * (decimal)0.22;
                            if (ticker.Contains("CI"))
                            {
                                offerCI = (decimal)grdDatos.Rows[0].Cells[4].Value;
                            }
                            if (ticker.Contains("48hs"))
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
                            ejercer = strike * (decimal)1.0022;
                            row.Cells[8].Value = ejercer;
                        }

                        row.Cells[6].Value = costo + offer;

                        //CI o 48hs
                        if (grdDatos.Rows[1].Cells[6].Value != null)
                        {
                            armar = (decimal)row.Cells[6].Value + (decimal)grdDatos.Rows[1].Cells[6].Value;
                        }
                        row.Cells[7].Value = armar;
                        if (armar == 0)
                        {
                            ratio = 0;
                        }
                        else
                        {
                            ratio = Math.Round(((ejercer / armar) - 1) * 100,2);
                        }
                        row.Cells[9].Value = ratio;
                        neto = Math.Round(ejercer - armar,2);
                        row.Cells[10].Value = neto;
                        if (ratio>0)
                        {
                            row.Cells[9].Style.ForeColor = Color.DarkGreen;
                        }
                        else
                        { 
                            row.Cells[9].Style.ForeColor = Color.Red;
                        }

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