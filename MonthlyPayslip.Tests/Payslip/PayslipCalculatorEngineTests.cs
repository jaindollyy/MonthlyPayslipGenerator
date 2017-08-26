using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonthlyPayslip.Calculator.Payslip;

namespace MonthlyPayslip.Tests
{
    [TestClass]
    public class PayslipCalculatorEngineTests
    {

        [TestMethod]
        public void PayslipEngineTest()
        {
        
                string[] Inputs = new string[]{"David,Rudd,60050,9%,01 March – 31 March",
                                    "Ryan,Chen,120000,10%,01 March – 31 March"};

                string[] Expected = new string[]{"David Rudd,01 March – 31 March,5004,922,4082,450",
                                    "Ryan Chen,01 March – 31 March,10000,2696,7304,1000"};

                List<string> Actual = new List<string> { };
                foreach (var input in Inputs)
                {
                    Actual.Add(PayslipCalculatorEngine.GetPayslip(input));
                }

                if (Inputs.Length != Expected.Length)
                {
                    Assert.Fail("Inputs collection are not same length");
                }          

                CollectionAssert.AreEqual(Expected, Actual);               
            }
           
        }    
}


