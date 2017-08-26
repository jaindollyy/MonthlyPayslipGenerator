using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonthlyPayslip.Calculator.IncomeTax;

namespace MonthlyPayslip.Tests
{
    [TestClass]
    public class TaxTableGeneratorTests
    { 
        [TestMethod]
        public void TaxTableGeneratorTest()
        {
            List<TaxTable> expected = new List<TaxTable>();
            expected.Add(new TaxTable(0, 18200, new TaxBracket(0,0,0)));
            expected.Add(new TaxTable(18201, 37000, new TaxBracket(0, 18200, 0.19m)));
            expected.Add(new TaxTable(37001, 80000, new TaxBracket(3572, 37000, 0.325m)));
            expected.Add(new TaxTable(80001, 180000, new TaxBracket(17547, 80000, 0.37m)));
            expected.Add(new TaxTable(180001, decimal.MaxValue, new TaxBracket(54547, 180000, 0.45m)));


            List<TaxTable> actual = new List<TaxTable>();
            TaxTableGenerator TaxTableGenerator = new TaxTableGenerator();
            actual = TaxTableGenerator.TaxTableData;

            if (expected.Count != actual.Count)
            {
                Assert.Fail("Collections are not same length");
            }

            Assert.AreEqual(expected[0].MaxThreshold, actual[0].MaxThreshold);
            Assert.AreEqual(expected[0].MinThreshold, actual[0].MinThreshold);
            Assert.AreEqual(expected[0].IncomeTaxBracket.AccumulatedTaxFromPreviousBracket, actual[0].IncomeTaxBracket.AccumulatedTaxFromPreviousBracket);
            Assert.AreEqual(expected[0].IncomeTaxBracket.IncomeThreshold, actual[0].IncomeTaxBracket.IncomeThreshold);
            Assert.AreEqual(expected[0].IncomeTaxBracket.MarginalTaxRate, actual[0].IncomeTaxBracket.MarginalTaxRate);
        }
    }
     
    
}



  