//Code Behind File - (CONTROLLER)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CurrencyConverterBCL;

namespace CurrencyConverterUserInterface
{
    public partial class ConverterUI : Form
    {
        Dictionary<string, double> ratesDictionary = new Dictionary<string, double>();

        public ConverterUI()
        {
            InitializeComponent();
        }

        //Variables to hold user input.
        private double usAmt;
        private string currencySymbol;

        //Method invoked when user clicks the 'Convert' button.
        private void RunConverter(object sender, EventArgs e)
        {
            //Checks if data is valid before running converter.
            if (GetDataAndValidate())
            {
                //Creats a new instance of the CurrencyConverterClass.
                Conversion myConversion = new Conversion();

                //Gets exchange rate from the dictionary.
                double exchangeRate = ratesDictionary[currencySymbol];

                myConversion.UsAmount = usAmt;
                myConversion.ExchangeRate = exchangeRate;

                myConversion.ConvertCurrency();

                FormatAndDisplayValues(myConversion.ConvertedValue, currencySymbol, exchangeRate);
            }
        }

        //Checks user input and if they selected a currency.
        private bool GetDataAndValidate()
        {
            bool valid = false;

            //Checks if text entered can be parsed into a double and the value parsed is >= zero.
            if (double.TryParse(usDollarTextBox.Text, out usAmt) && usAmt >= 0.0)
            {
                int selectedIndex = lbCurrencies.SelectedIndex;

                if (selectedIndex != -1)
                {
                    currencySymbol = lbCurrencies.Text;
                    valid = true;
                }
                else
                {
                    //Error message if user did not select a currency.
                    MessageBox.Show("Please select a currency.");
                    lbCurrencies.Focus();
                }
            }
            else
            {
                //Error message if text entered is invalid.
                MessageBox.Show("Invalid input.");
                usDollarTextBox.Focus();
            }

            return valid;
        }

        //Formats and displays converted value in appropriate textbox
        private void FormatAndDisplayValues(double convertedValue, string currencySymbol, double exchangeRate)
        {
            string resultStringPrimary = currencySymbol + " " + convertedValue.ToString("n2");

            //Uses thousands separator and two decimal place format. 36 is max length I am allowing inside the label.
            if (resultStringPrimary.Length < 37)
            {
                convertedValueLabel.Text = resultStringPrimary;
            }
            //Uses scientific notation if string is too long for label.
            else
            {
                string resultStringSecondary = currencySymbol + " " + convertedValue.ToString("e2");
                convertedValueLabel.Text = resultStringSecondary;
            }

            lblExchangeRate.Text = exchangeRate.ToString();
        }

        //Clears data and resets form to startup.
        private void ClearAndReset(object sender, EventArgs e)
        {
            usDollarTextBox.Text = string.Empty;
            lbCurrencies.SelectedIndex = -1;
            convertedValueLabel.Text = string.Empty;
            lblExchangeRate.Text = string.Empty;
            usDollarTextBox.Focus();
        }

        //Exits application.
        private void ExitApplication(object sender, EventArgs e)
        {
            this.Close();
        }

        //Loads all currencies into the currencyListBox.
        private void ConverterUI_Load(object sender, EventArgs e)
        {
            string url = "https://api.exchangeratesapi.io/latest?base=USD";

            API_Request_BCL myBCL = new API_Request_BCL();

            ratesDictionary = myBCL.RequestDataFromAPI_URL(url);

            bsCurrencyRates.DataSource = ratesDictionary;

            lbCurrencies.SelectedIndex = -1;

            /* 
             * Without using object data sources/binding source:
             * 
             * List<string> symbols = new List<string>(ratesDictionary.Keys);
             * 
             * lbCurrencies.DataSource = symbols;
            */
        }
    }
}
