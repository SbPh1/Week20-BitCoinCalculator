using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitCoinCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getRatesBTN_Click(object sender, EventArgs e)
        {
            if(currencyMenu.SelectedItem.ToString() == "EUR")
            {
                resultLBL.Visible = true;
                result.Visible = true;

                BitCoinRates resultRates = GetRates();
                int userCoins = Int32.Parse(amountOfBC.Text); // the amount of user's bitcoins

                float currentRate = resultRates.bpi.EUR.rate_float; // current bitcoin rate in EUR
                float BCResult = userCoins * currentRate;
                result.Text = $"{BCResult} {resultRates.bpi.EUR.code}";
            }
            else if(currencyMenu.SelectedItem.ToString() == "USD")
            {
                resultLBL.Visible = true;
                result.Visible = true;

                BitCoinRates resultRates = GetRates();
                int userCoins = Int32.Parse(amountOfBC.Text);

                float currentRate = resultRates.bpi.USD.rate_float;
                float BCResult = userCoins * currentRate;
                result.Text = $"{BCResult} {resultRates.bpi.USD.code}";
            }
            else
            {
                resultLBL.Visible = true;
                result.Visible = true;

                BitCoinRates resultRates = GetRates();
                int userCoins = Int32.Parse(amountOfBC.Text);

                float currentRate = resultRates.bpi.GBP.rate_float;
                float BCResult = userCoins * currentRate;
                result.Text = $"{BCResult} {resultRates.bpi.GBP.code}";
            }



        }

        public static BitCoinRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            BitCoinRates bitcoin;

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using(var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitCoinRates>(response);
            }

            return bitcoin;
        }
    }
}
