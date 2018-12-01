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

namespace CurrencyConverter
{
    public partial class ConverterUI : Form
    {
        public ConverterUI()
        {
            InitializeComponent();
        }

        //Variables to hold user input.
        private double dollarAmtEntered;
        private string currency;

        //Method invoked when user clicks the 'Convert' button.
        private void RunConverter(object sender, EventArgs e)
        {
            //Checks if data is valid before running converter.
            if (GetDataAndValidate())
            {
                //Creats a new instance of the CurrencyConverterClass.
                CurrencyConverterClass myConverter = new CurrencyConverterClass();

                //Sets values and converts to selected currency.
                myConverter.SetValues(dollarAmtEntered, currency);
                myConverter.ConvertCurrency();

                //Stores converted value and new currency symbol.
                double convertedValue = myConverter.GetConvertedValue();
                string currencySymbol = GetCurrencySymbol(currency);

                FormatAndDisplayValue(convertedValue, currencySymbol);
            }
        }

        //Checks user input and if they selected a currency.
        private bool GetDataAndValidate()
        {
            bool valid = false;

            //Checks if text entered can be parsed into a double and the value parsed is >= zero.
            if (double.TryParse(usDollarTextBox.Text, out dollarAmtEntered) && dollarAmtEntered >= 0.0)
            {
                if (currencyListBox.SelectedIndex != -1)
                {
                    currency = currencyListBox.SelectedItem.ToString();
                    valid = true;
                }
                else
                {
                    //Error message if user did not select a currency.
                    MessageBox.Show("Please select a currency.");
                    currencyListBox.Focus();
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

        //Gets and returns the currency symbol from the currency string.
        private string GetCurrencySymbol(string currency)
        {
            string symbol;
            int pos1, pos2;

            pos1 = currency.IndexOf('(') + 1;
            pos2 = currency.IndexOf(')');
            symbol = currency.Substring(pos1, pos2 - pos1);

            return symbol;
        }

        //Formats and displays converted value in appropriate textbox
        private void FormatAndDisplayValue(double value, string symbol)
        {
            string resultStringPrimary = symbol + " " + value.ToString("n2");

            //Uses thousands separator and two decimal place format. 39 is max length inside label.
            if (resultStringPrimary.Length < 39)
            {
                convertedValueLabel.Text = resultStringPrimary;
            }
            //Uses scientific notation if string is too long for label.
            else
            {
                string resultStringSecondary = symbol + " " + value.ToString("e");
                convertedValueLabel.Text = resultStringSecondary;
            }
        }

        //Clears data and resets form to startup.
        private void ClearAndReset(object sender, EventArgs e)
        {
            usDollarTextBox.Text = "";
            currencyListBox.SelectedIndex = -1;
            convertedValueLabel.Text = "";
            usDollarTextBox.Focus();
        }

        //Exits application.
        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Loads all currencies into the currencyListBox.
        private void ConverterUI_Load(object sender, EventArgs e)
        {
            currencyListBox.Items.Add("Australian Dollar (AU$)");
            currencyListBox.Items.Add("Chinese Yuan (CNY)");
            currencyListBox.Items.Add("Euro (€)");
            currencyListBox.Items.Add("Japanese Yen (JPY)");
            currencyListBox.Items.Add("UK Pound (£)");
        }
    }
}
