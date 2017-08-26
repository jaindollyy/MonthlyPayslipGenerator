

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonthlyPayslip.Calculator.IncomeTax;

namespace MonthlyPayslip.Tests
{
    [TestClass]
    public class TaxBracketTests
    {
        [TestMethod]
        public void TaxBracketTest()
        {
            TaxBracket expected = new TaxBracket(3572, 37000, 0.325m);

            Assert.AreEqual(expected.AccumulatedTaxFromPreviousBracket, 3572m);
            Assert.AreEqual(expected.MarginalTaxRate, 37000m);
            Assert.AreEqual(expected.IncomeThreshold, 0.325m);           
        }
    }
}
