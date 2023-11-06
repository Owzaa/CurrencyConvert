using CurrencyConverter;
using System;

namespace CurrencyConverter
{
    public class CurrencyConvectionService
    {
        private CurrencyConverterApi currencyConverter;

        public CurrencyConvectionService(string apiKey)
        {
            currencyConverter = new CurrencyConverterApi(apiKey);
        }

        internal double ConvertCurrency(double amountToConvert, string fromCurrency, string toCurrency)
        {
            throw new NotImplementedException();
        }
    }

    internal class CurrencyConverterApi
    {
        private string apiKey;

        public CurrencyConverterApi(string apiKey)
        {
            this.apiKey = apiKey;
        }

        internal object GetLatestRates(string fromCurrency)
        {
            throw new NotImplementedException();
        }
    }
}