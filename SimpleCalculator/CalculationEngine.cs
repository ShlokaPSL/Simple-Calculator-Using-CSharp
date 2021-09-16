using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculationEngine
    {
        public double CalculateResult(string operation, double firstNum, double secondNum)
        {
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    if (secondNum == 0)
                        throw new ArgumentException("Divide By Zero Not Possible.");

                    result = firstNum / secondNum;
                    break;
                default:
                    throw new ArgumentException("Operation Not Possible.");
            }

            return result;
        }
    }
}