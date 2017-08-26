using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonthlyPayslip.Calculator.Helper;
using MonthlyPayslip.Calculator.IncomeTax;

namespace MonthlyPayslip.Tests
{
    [TestClass]
    public class IncomeTaxCalculatorTests
    {
        [TestMethod]
        public void CalculateMonthlyPayableIncomeTaxTest()
        {
            decimal expected = 922m;
            decimal annualTaxableIncome = 60050;

            TaxCalculator taxCalculator = new TaxCalculator();
            var taxBracket = taxCalculator.GetTaxBracket(annualTaxableIncome);

            var marginalTax = taxCalculator.CalculateMarginalTax(annualTaxableIncome, taxBracket);

            var monthlyIncomeTax = (taxBracket.AccumulatedTaxFromPreviousBracket + marginalTax) / Constants.MonthsInYear;

            decimal actual = DecimalExtensionMethods.RoundValue(monthlyIncomeTax);

            Assert.AreEqual(expected, actual);


        }

    }
}
