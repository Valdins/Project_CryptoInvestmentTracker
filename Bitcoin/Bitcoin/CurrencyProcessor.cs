using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bitcoin
{
    class CurrencyProcessor
    {
        public static async Task<CurrencyModel> LoadCurrency()
        {
            string url = "http://data.fixer.io/api/latest?access_key=c8250b0adab21c32ef6d73ebbab7a0e8";

            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    CurrencyResultModel rates = await response.Content.ReadAsAsync<CurrencyResultModel>();

                    return rates.Rates;
                }
                else
                    throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
