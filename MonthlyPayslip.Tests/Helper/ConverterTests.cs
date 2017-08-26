using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonthlyPayslip.Calculator.Helper;

namespace MonthlyPayslip.Tests
{
    [TestClass]
    public class ConverterTests
    {
        [TestMethod]
        public void  ConvertStringToPercentageTest()
        {
            string input = "9%";
            decimal expected = 0.09m;
            decimal actual= Converter.StringPercentageToDecimal(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void  ConvertStringToDecimalTest()
        {
            string input = "90000";
            decimal expected = 90000;
            decimal actual= Converter.StringToDecimal(input);

            Assert.AreEqual(expected,actual);
        }

    }
}
