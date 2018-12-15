using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourFunctionCalculator_v2
{
    public partial class Calculator2 : Form
    {
        public Calculator2()
        {
            InitializeComponent();
        }

        private double inputNumber1;
        private double inputNumber2;

        private void RunCalculator(string operationCode)
        {
            if(IsValid(inputTextBox1.Text, inputTextBox2.Text, operationCode))
            {
                double result = PerformCalculation.Calculate(inputNumber1, inputNumber2, operationCode);
                resultsLabel.Text = result.ToString("n2");
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private bool IsValid(string number1, string number2, string operationCode)
        {
            bool valid = false;

            if(double.TryParse(number1, out inputNumber1))
            {
                if (double.TryParse(number2, out inputNumber2))
                {
                    if (inputNumber2 == 0.0 && operationCode == "/")
                    {
                        valid = false;
                    }
                    else
                    {
                        valid = true;
                    }
                }
            }

            return valid;
        }

        
        private void ClearAll()
        {
            inputTextBox1.Clear();
            inputTextBox2.Clear();

            resultsLabel.Text = "";

            inputTextBox1.Focus();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            RunCalculator("+");
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            RunCalculator("-");
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            RunCalculator("*");
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            RunCalculator("/");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
