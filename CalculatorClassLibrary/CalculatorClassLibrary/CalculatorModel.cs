using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
    public class CalculatorModel
    {
        //Class Variables
        private double _number1;
        private double _number2;
        private string _opCode;
        private double _result;

        //Constructor
        public CalculatorModel()
        {
            _number1 = 0.0;
            _number2 = 0.0;
            _opCode = "";
            _result = 0.0;
        }

        //Property methods - getters and setters
        //Setters for number1, number2, and opCode
        //Getter for result
        public double Number1 //Write only
        {
            set { _number1 = value; }
        }

        public double Number2 //Write only
        {
            set { _number2 = value; }
        }

        public string OperationCode //Write only
        {
            set { _opCode = value; }
        }

        public double Result //Read only
        {
            get { return _result; }
        }

        /// <summary>
        /// Method to perform calculation depending on what operation is selected.
        /// </summary>
        public void PerformCalculation()
        {
            switch (_opCode)
            {
                case "+":
                    _result = Math.Round(_number1 + _number2, 2, MidpointRounding.AwayFromZero);
                    break;
                case "-":
                    _result = Math.Round(_number1 - _number2, 2,MidpointRounding.AwayFromZero);
                    break;
                case "*":
                    _result = Math.Round(_number1 * _number2, 2, MidpointRounding.AwayFromZero);
                    break;
                case "/":
                    _result = Math.Round(_number1 / _number2, 2, MidpointRounding.AwayFromZero);
                    break;
                case "^":
                    _result = Math.Round(Math.Pow(_number1, _number2), 2, MidpointRounding.AwayFromZero);
                    break;
                default:
                    break;
            }
        }
    }
}
