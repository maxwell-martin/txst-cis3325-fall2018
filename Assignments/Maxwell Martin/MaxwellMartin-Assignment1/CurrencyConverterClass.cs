//CurrencyConverterClass - (MODEL)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxwellMartin_Assignment1
{
    class CurrencyConverterClass
    {
        //Property Variables.
        private double usAmount = 0.0;
        private double convertedValue = 0.0;
        private string currencyToConvertTo = "";

        //Conversion Rates.
        private const double AU_DOLLAR = 1.40760;
        private const double CNY = 6.8421;
        private const double EURO = 0.86483;
        private const double JPY = 111.08276;
        private const double BRITISH_POUND = 0.77385;

        //Sets US dollar amt entered and currency selected to respective property variables.
        public void SetValues(double usDollarAmt, string selectedCurrency)
        {
            usAmount = usDollarAmt;
            currencyToConvertTo = selectedCurrency;
        }

        //Converts US dollar amt entered to currency selected.
        public void ConvertCurrency()
        {
            switch (currencyToConvertTo)
            {
                case "Australian Dollar (AU$)":
                    convertedValue = usAmount * AU_DOLLAR;
                    break;
                case "Chinese Yuan (CNY)":
                    convertedValue = usAmount * CNY;
                    break;
                case "Euro (€)":
                    convertedValue = usAmount * EURO;
                    break;
                case "Japanese Yen (JPY)":
                    convertedValue = usAmount * JPY;
                    break;
                case "UK Pound (£)":
                    convertedValue = usAmount * BRITISH_POUND;
                    break;
                default:
                    break;
            }
        }

        //Returns converted US dollar amt to whatever currency that was used for conversion.
        public double GetConvertedValue()
        {
            return convertedValue;
        }
    }
}
