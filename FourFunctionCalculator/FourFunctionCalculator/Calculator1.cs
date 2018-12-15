using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourFunctionCalculator
{
    public partial class Calculator1 : Form
    {
        public Calculator1()
        {
            InitializeComponent();
        }

        double result;
        double inputNumber1;
        double inputNumber2;

        private bool IsValid(string number1, string number2)
        {
            if(double.TryParse(number1, out inputNumber1))
            {
                if (double.TryParse(number2, out inputNumber2))
                {
                    return true;
                }
                
            }

            return false;
        }

        private double Add(double x, double y)
        {
            return x + y;
        }

        private double Subtract(double x, double y)
        {
            return x - y;
        }

        private double Multiply(double x, double y)
        {
            return x * y;
        }

        private double Divide(double x, double y)
        {
            return x / y;
        }

        private void ClearAll()
        {
            inputTextBox1.Clear();
            inputTextBox2.Clear();

            resultsLabel.Text = "";

            inputNumber1 = 0.0;
            inputNumber2 = 0.0;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string inputText1 = inputTextBox1.Text;
            string inputText2 = inputTextBox2.Text;

            if (IsValid(inputText1, inputText2))
            {
                result = Add(inputNumber1, inputNumber2);

                resultsLabel.Text = result.ToString("n2");
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            string inputText1 = inputTextBox1.Text;
            string inputText2 = inputTextBox2.Text;

            if (IsValid(inputText1, inputText2))
            {
                result = Subtract(inputNumber1, inputNumber2);

                resultsLabel.Text = result.ToString("n2");
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            string inputText1 = inputTextBox1.Text;
            string inputText2 = inputTextBox2.Text;

            if (IsValid(inputText1, inputText2))
            {
                result = Multiply(inputNumber1, inputNumber2);

                resultsLabel.Text = result.ToString("n2");
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            string inputText1 = inputTextBox1.Text;
            string inputText2 = inputTextBox2.Text;

            if (IsValid(inputText1, inputText2))
            {
                if (inputNumber2 !=0 )
                {
                    result = Divide(inputNumber1, inputNumber2);

                    resultsLabel.Text = result.ToString("n2");
                }
                else
                {
                    MessageBox.Show("You cannot divide by ZERO (0).");
                }
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
