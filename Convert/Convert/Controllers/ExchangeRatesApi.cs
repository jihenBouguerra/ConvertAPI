using Convert.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Convert.Controllers
{
    public class ExchangeRatesApi
    {
        private static readonly string _baseUrl = "https://api.exchangeratesapi.io";

        public static Double GetRate(string baseCurrency, string targetCurrency)
        {
            var url = new StringBuilder().AppendFormat(
                _baseUrl + "/latest?base={0}&symbols={1}",
                baseCurrency,
                targetCurrency
                ).ToString();
            var syncClient = new WebClient();
            var content = syncClient.DownloadString(url);
            Rate rate = JsonConvert.DeserializeObject<Rate>(content);
            return rate.Rates.GetValueOrDefault<string,double>(targetCurrency);
        }
    }
}
