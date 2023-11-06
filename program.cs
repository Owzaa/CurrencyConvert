using CurrencyConverter;
using System;

class Program
{
    static void Main(string[] args)
    {
        string apiKey = "3a68607f731086f8be9015775c2e4d28";
        CurrencyConvectionService conversionService = new CurrencyConversionService(apiKey);

        try
        {
            double amountToConvert = 100; // Change this to your desired amount
            string fromCurrency = "USD";
            string toCurrency = "EUR";

            double convertedAmount = conversionService.ConvertCurrency(amountToConvert, fromCurrency, toCurrency);

            Console.WriteLine($"{amountToConvert} {fromCurrency} is equivalent to {convertedAmount} {toCurrency}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

internal class CurrencyConversionService : CurrencyConvectionService
{
    public CurrencyConversionService(string apiKey) : base(apiKey)
    {
    }
}