using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool goAgain = true;

                while (goAgain)
                {
                    InputConverter inputConverter = new InputConverter();
                    CalculationEngine calculationEngine = new CalculationEngine();

                    Console.WriteLine("Enter First Number");
                    double firstNum = inputConverter.ConvertToNumber(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    double secondNum = inputConverter.ConvertToNumber(Console.ReadLine());
                    Console.WriteLine("Enter Operator");
                    string operation = inputConverter.ConvertToOperator(Console.ReadLine());

                    double result = calculationEngine.CalculateResult(operation, firstNum, secondNum);

                    Console.WriteLine("Result of {0} {1} {2} = {3}", firstNum, operation, secondNum, result);

                    Console.WriteLine("\n\nDo you want to go again? [1: YES, 2: NO] ");
                    string input = Console.ReadLine();

                    if (input != "1")
                        goAgain = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exiting Application...");
            }
        }
    }
}