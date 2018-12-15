using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterBCL
{
    public class Rates
    {
        private string date;
        private Dictionary<string, double> currencyRates;
        private string baseCurrency;

        public Rates()
        {
            //Default constructor.
        }

        public string Date { get => date; set => date = value; }
        public Dictionary<string, double> CurrencyRates { get => currencyRates; set => currencyRates = value; }
        public string CurrencyBase { get => baseCurrency; set => baseCurrency = value; }
    }
}
