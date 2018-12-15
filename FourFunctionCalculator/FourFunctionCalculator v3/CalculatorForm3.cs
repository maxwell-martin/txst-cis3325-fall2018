using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorClassLibrary;

namespace FourFunctionCalculator_v3
{
    public partial class CalculatorForm3 : Form
    {
        public CalculatorForm3()
        {
            InitializeComponent();
        }

        private double inputNumber1;
        private double inputNumber2;

        private void RunCalculator(object sender, EventArgs e)
        {
            if (IsValid(inputTextBox1.Text, inputTextBox2.Text, ((Button)sender).Text))
            {
                CalculatorModel myCalculator = new CalculatorModel();

                myCalculator.Number1 = inputNumber1;
                myCalculator.Number2 = inputNumber2;
                myCalculator.OperationCode = ((Button)sender).Text;
                myCalculator.PerformCalculation();

                string result = myCalculator.Result.ToString("n2");

                if (result.Length > 30)
                    resultsLabel.Text = myCalculator.Result.ToString("e4");
                else
                    resultsLabel.Text = result;
            }
        }

        private bool IsValid(string number1, string number2, string operationCode)
        {
            bool valid = false;

            if (double.TryParse(number1, out inputNumber1) && double.TryParse(number2, out inputNumber2))
            {
                if (inputNumber2 == 0 && operationCode == "/")
                {
                    resultsLabel.Font = new Font("Microsoft Sans Serif", 15);
                    resultsLabel.Text = "Error - Division by Zero";
                }
                else
                {
                    valid = true;
                    resultsLabel.Font = new Font("Microsoft Sans Serif", 11);
                }
            }
            else
            {
                resultsLabel.Font = new Font("Microsoft Sans Serif", 15);
                resultsLabel.Text = "Error";
            }

            return valid;
        }

        private void ClearAll(object sender, EventArgs e)
        {
            inputTextBox1.Clear();
            inputTextBox2.Clear();

            resultsLabel.Text = "";

            inputTextBox1.Focus();
        }

        private void CloseProgram(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
