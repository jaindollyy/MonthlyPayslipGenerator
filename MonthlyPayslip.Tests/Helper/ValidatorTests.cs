using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonthlyPayslip.Calculator.Helper;

namespace MonthlyPayslip.Tests
{
    [TestClass]
    public class ValidatorTests
    {
        
        [TestMethod]
        public void  IsValidTaxTableItem()
        {
            decimal annualTaxableIncome = 60000;
            decimal minThreshold = 0;
            decimal maxThreshold = 80000;

            Assert.IsTrue(Validator.IsValidTaxTableItem(annualTaxableIncome, minThreshold, maxThreshold));
        }

        [TestMethod]
        public void IsBetween()
        {
            decimal min = 3000;
            decimal max = 6000;           
            Assert.IsTrue(Validator.IsBetween(min,max));
        }

    }
}
