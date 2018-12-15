//CurrencyConverterClass - (MODEL)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterBCL
{
    public class Conversion
    {
        //Property Variables.
        private double usAmount;
        private double exchangeRate;
        private double convertedValue;

        public Conversion()
        {
            //Default constructor.
        }

        public double UsAmount { get => usAmount; set => usAmount = value; }
        public double ExchangeRate { get => exchangeRate; set => exchangeRate = value; }
        public double ConvertedValue { get => convertedValue; set => convertedValue = value; }

        //Converts US dollar amt entered to currency selected.
        public void ConvertCurrency()
        {
            ConvertedValue = UsAmount * ExchangeRate;
        }
    }
}
