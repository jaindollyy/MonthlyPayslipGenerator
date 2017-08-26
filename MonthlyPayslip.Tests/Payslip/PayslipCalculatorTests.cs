using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonthlyPayslip.Calculator.Payslip;

namespace MonthlyPayslip.Tests
{
    [TestClass]
    public class PayslipCalculatorTests
    {
        [TestMethod]
        public void PayslipCalculatorTest()
        {
            string Input = "David,Rudd,60050,9%,01 March – 31 March";
            string Expected = "David Rudd,01 March – 31 March,5004,922,4082,450";
            string Actual;

            PayslipInput payslipInput;
            PayslipInfo payslipInfo;

            var inputProcessor = new InputProcessor();
            var payslipCalculator = new PayslipCalculator();
            var outputProcessor = new OutputProcessor();

            payslipInput = inputProcessor.Process(Input);
            payslipInfo = payslipCalculator.Calculate(payslipInput);
            Actual = outputProcessor.Process(payslipInfo);
            Assert.AreEqual(Expected, Actual);
        }
    }
}



