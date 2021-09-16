using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTests
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertsValidStringNumberInputToDoubleNumber()
        {
            string input = "5";

            double convertedInput = _inputConverter.ConvertToNumber(input);

            Assert.AreEqual(5, convertedInput);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringNumberInputToDoubleNumber()
        {
            string input = "abc";

            double convertedInput = _inputConverter.ConvertToNumber(input);
        }

        [TestMethod]
        public void ConvertsValidStringAddOperatorInputToAdditionSymbol()
        {
            string input = "Add";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("+", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringaddOperatorInputToAdditionSymbol()
        {
            string input = "add";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("+", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringADDOperatorInputToAdditionSymbol()
        {
            string input = "ADD";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("+", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringAdditionOperatorInputToAdditionSymbol()
        {
            string input = "Addition";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("+", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringadditionOperatorInputToAdditionSymbol()
        {
            string input = "addition";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("+", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringADDITIONOperatorInputToAdditionSymbol()
        {
            string input = "ADDITION";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("+", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringSubOperatorInputToSubtractionSymbol()
        {
            string input = "Sub";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("-", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringsubOperatorInputToSubtractionSymbol()
        {
            string input = "sub";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("-", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringSUBOperatorInputToSubtractionSymbol()
        {
            string input = "SUB";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("-", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringSubtractOperatorInputToSubtractionSymbol()
        {
            string input = "Subtract";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("-", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringsubtractOperatorInputToSubtractionSymbol()
        {
            string input = "subtract";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("-", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringSUBTRACTOperatorInputToSubtractionSymbol()
        {
            string input = "SUBTRACT";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("-", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringSubtractionOperatorInputToSubtractionSymbol()
        {
            string input = "Subtraction";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("-", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringsubtractionOperatorInputToSubtractionSymbol()
        {
            string input = "subtraction";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("-", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringSUBTRACTIONOperatorInputToSubtractionSymbol()
        {
            string input = "SUBTRACTION";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("-", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringMulOperatorInputToMultiplicationSymbol()
        {
            string input = "Mul";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("*", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringmulOperatorInputToMultiplicationSymbol()
        {
            string input = "mul";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("*", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringMULOperatorInputToMultiplicationSymbol()
        {
            string input = "MUL";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("*", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringMultiplyOperatorInputToMultiplicationSymbol()
        {
            string input = "Multiply";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("*", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringmultiplyOperatorInputToMultiplicationSymbol()
        {
            string input = "multiply";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("*", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringMULTIPLYOperatorInputToMultiplicationSymbol()
        {
            string input = "MULTIPLY";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("*", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringMultiplicationOperatorInputToMultiplicationSymbol()
        {
            string input = "Multiplication";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("*", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringmultiplicationOperatorInputToMultiplicationSymbol()
        {
            string input = "multiplication";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("*", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringMULTIPLICATIONOperatorInputToMultiplicationSymbol()
        {
            string input = "MULTIPLICATION";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("*", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringDivOperatorInputToDivisionSymbol()
        {
            string input = "Div";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("/", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringdivOperatorInputToDivisionSymbol()
        {
            string input = "div";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("/", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringDIVOperatorInputToDivisionSymbol()
        {
            string input = "DIV";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("/", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringDivideOperatorInputToDivisionSymbol()
        {
            string input = "Divide";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("/", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringdivideOperatorInputToDivisionSymbol()
        {
            string input = "divide";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("/", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringDIVIDEOperatorInputToDivisionSymbol()
        {
            string input = "DIVIDE";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("/", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringDivisionOperatorInputToDivisionSymbol()
        {
            string input = "Division";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("/", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringdivisionOperatorInputToDivisionSymbol()
        {
            string input = "division";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("/", convertedInput);
        }

        [TestMethod]
        public void ConvertsValidStringDIVISIONOperatorInputToDivisionSymbol()
        {
            string input = "DIVISION";

            string convertedInput = _inputConverter.ConvertToOperator(input);

            Assert.AreEqual("/", convertedInput);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringOperatorInputToOperatorSymbol()
        {
            string input = "&";

            string convertedInput = _inputConverter.ConvertToOperator(input);
        }
    }
}
