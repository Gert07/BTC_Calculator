using Newtonsoft.Json;
using System.Net;
using static System.Net.WebRequestMethods;

namespace Bitcoin_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sihtvaluuta_Click(object sender, EventArgs e)
        {

        }

        public static BTCRates BitcoinRates()
        {
            string URL = "https://data-api.coindesk.com/index/cc/v1/latest/tick?market=cadli&instruments=BTC-USD,BTC-EUR,BTC-GBP&apply_mapping=true&api_key=090c53750b85c3411e7dd35c5c0eabfaf00bb9911cf5d8b58492c34b1f7f857c";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BTCRates newbitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
                var data = responseReader.ReadToEnd();
                newbitcoin = JsonConvert.DeserializeObject<BTCRates>(data);
            }
            return newbitcoin;
        }

        private void GetRate_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    currency_selector.SelectedItem.ToString() != "USD" &&
                    currency_selector.SelectedItem.ToString() != "EUR" &&
                    currency_selector.SelectedItem.ToString() != "GBP" &&
                    currency_selector.SelectedItem.ToString() != "EKr"
                    )
                {
                    MessageBox.Show("Error", "VALUUTA ON VALIMATA");
                }

                else if (currency_selector.SelectedItem.ToString() == "USD")
                {
                    BTCRates newRate = BitcoinRates();
                    float result = (float)(float.Parse(btc_amout_input.Text) * newRate.Data.BTCUSD.VALUE);
                    btcResultLabel.Text = result.ToString();
                }
                else if (currency_selector.SelectedItem.ToString() == "EUR")
                {
                    BTCRates newRate = BitcoinRates();
                    float result = (float)(float.Parse(btc_amout_input.Text) * newRate.Data.BTCEUR.VALUE);
                    btcResultLabel.Text = result.ToString();
                }
                else if (currency_selector.SelectedItem.ToString() == "GBP")
                {
                    BTCRates newRate = BitcoinRates();
                    float result = (float)(float.Parse(btc_amout_input.Text) * newRate.Data.BTCGBP.VALUE);
                    btcResultLabel.Text = result.ToString();
                }
                else if (currency_selector.SelectedItem.ToString() == "EKr")
                {
                    BTCRates newRate = BitcoinRates();
                    float result = (float)(float.Parse(btc_amout_input.Text) * newRate.Data.BTCEUR.VALUE * 15.6466);
                    btcResultLabel.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tekkis viga, vea detailid: {ex.Message}", $"{ex}");
            }
        }

        private void currency_selector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btcResultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
