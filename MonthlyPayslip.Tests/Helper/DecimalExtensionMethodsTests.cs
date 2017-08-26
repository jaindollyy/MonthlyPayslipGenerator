using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonthlyPayslip.Calculator.Helper;

namespace MonthlyPayslip.Tests
{
    [TestClass]
    public class DecimalExtensionMethodsTests
    {    
            
        [TestMethod]
        public void RoundValueTest()
        {
            decimal value = 8.56m;

            DecimalExtensionMethods.RoundValue(value);
            Assert.AreEqual(Math.Round(value, 1), 8.6m);
            Assert.AreEqual(Math.Round(value, 0), 9m);        

        }
    }
}
