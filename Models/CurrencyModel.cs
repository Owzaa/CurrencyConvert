using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyConverter.Models
{
    public class Currency
    {
        
    public string Code { get; set; } // Currency code (e.g., USD, EUR)
        public string Name { get; set; } // Currency name (e.g., United States Dollar, Euro)
        public string Symbol { get; set; } // Currency symbol (e.g., $, €)
        public double ExchangeRate { get; set; } // Exchange rate against a base currency (e.g., USD)

        public Currency(string code, string name, string symbol, double exchangeRate)
        {
            Code = code;
            Name = name;
            Symbol = symbol;
            ExchangeRate = exchangeRate;
        }

        public override string ToString()
        {
            return $"{Code} - {Name} ({Symbol})";
        }
    }



}
