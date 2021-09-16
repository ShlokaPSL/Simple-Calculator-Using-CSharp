using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculationEngineTests
    {
        private readonly SimpleCalculator.CalculationEngine _calculationEngine = new SimpleCalculator.CalculationEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResult()
        {
            double num1 = 5;
            double num2 = 2;

            double result = _calculationEngine.CalculateResult("+", num1, num2);

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void SubtractsTwoNumbersAndReturnsValidResult()
        {
            double num1 = 5;
            double num2 = 2;

            double result = _calculationEngine.CalculateResult("-", num1, num2);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MultipliesTwoNumbersAndReturnsValidResult()
        {
            double num1 = 5;
            double num2 = 2;

            double result = _calculationEngine.CalculateResult("*", num1, num2);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void DividesTwoNumbersAndReturnsValidResult()
        {
            double num1 = 5;
            double num2 = 2;

            double result = _calculationEngine.CalculateResult("/", num1, num2);

            Assert.AreEqual(2.5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToDivideByZero()
        {
            double num1 = 5;
            double num2 = 0;

            double result = _calculationEngine.CalculateResult("/", num1, num2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToPerformOperationAndReturnResult()
        {
            double num1 = 5;
            double num2 = 2;

            double result = _calculationEngine.CalculateResult("&", num1, num2);
        }
    }
}
