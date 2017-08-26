using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonthlyPayslip.Calculator.Payslip;

namespace MonthlyPayslip.Tests
{
    [TestClass]
    public class OutputProcessorTests
    {
        [TestMethod]
        public void ProcessOutputTest()
        {
            string expected = "David Rudd,01 March - 31 March,5004,922,4082,450";

            PayslipInfo payslipInfo = new PayslipInfo(new Calculator.Entities.Employee("David", "Rudd")
                , "01 March - 31 March", 0.09m, 5004, 922, 4082, 450);

            var outputProcessor = new OutputProcessor();
            string actual = outputProcessor.Process(payslipInfo);

            Assert.AreEqual(expected, actual);

        }
    }
}


