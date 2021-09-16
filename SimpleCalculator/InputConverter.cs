using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertToNumber(string inputNumber)
        {
            double convertedNumber;

            if (!double.TryParse(inputNumber, out convertedNumber))
                throw new ArgumentException("Expected a Numeric Value.");

            return convertedNumber;
        }

        public string ConvertToOperator(string inputOperator)
        {
            string convertedOperator;

            if (inputOperator == "+" || inputOperator.ToLower() == "add" || inputOperator.ToLower() == "addition")
                convertedOperator = "+";
            else if (inputOperator == "-" || inputOperator.ToLower() == "sub" || inputOperator.ToLower() == "subtract" || inputOperator.ToLower() == "subtraction")
                convertedOperator = "-";
            else if (inputOperator == "*" || inputOperator.ToLower() == "mul" || inputOperator.ToLower() == "multiply" || inputOperator.ToLower() == "multiplication")
                convertedOperator = "*";
            else if (inputOperator == "/" || inputOperator.ToLower() == "div" || inputOperator.ToLower() == "divide" || inputOperator.ToLower() == "division")
                convertedOperator = "/";
            else
                throw new ArgumentException("Invalid operator");

            return convertedOperator;
        }
    }
}