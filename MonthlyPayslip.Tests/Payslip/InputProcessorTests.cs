using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonthlyPayslip.Calculator.Entities;
using MonthlyPayslip.Calculator.Payslip;

namespace MonthlyPayslip.Tests
{
    [TestClass]
    public class InputProcessorTests
    {
        [TestMethod]
        public void  ProcessInputTest()
        {
            string input = "David,Rudd,60050,9%,01 March – 31 March";

            var inputProcessor = new InputProcessor();
            PayslipInput expected = inputProcessor.Process(input);

            Assert.AreEqual(expected.Employee.FullName, "David Rudd");
            Assert.AreEqual(expected.PayPeriod, "01 March – 31 March");
            Assert.AreEqual(expected.Salary, 60050m);
            Assert.AreEqual(expected.SuperRate, 0.09m);
        }       
    }
}


