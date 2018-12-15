using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourFunctionCalculator_v2
{
    class PerformCalculation
    {
        internal static double Calculate(double number1, double number2, string operationCode)
        {
            double answer = 0.0;

            switch (operationCode)
            {
                case "+":
                    answer = number1 + number2;
                    break;
                case "-":
                    answer = number1 - number2;
                    break;
                case "*":
                    answer = number1 * number2;
                    break;
                case "/":
                    answer = number1 / number2;
                    break;
                default:
                    break;
            }

            return answer;
        }
    }
}
