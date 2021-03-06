using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConvertor = new InputConverter();

        [TestMethod]
        public void ConvertValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConvertor.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string inputNumber = "*";
            double convertedNumber = _inputConvertor.ConvertInputToNumeric(inputNumber);
        }

    }
}
