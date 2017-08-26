using System;
using System.Linq;
using MonthlyPayslip.Calculator.Helper;

namespace MonthlyPayslip.Calculator.IncomeTax
{
    public class TaxCalculator
    {
        
        private TaxTableGenerator TaxTableGenerator { get; }

        public TaxCalculator()
        {
            TaxTableGenerator = new TaxTableGenerator();
        }

        public decimal CalculateMonthlyPayableIncomeTax(decimal annualTaxableIncome)
        {
            Validator.IsValidValue(annualTaxableIncome);

            var taxBracket = GetTaxBracket(annualTaxableIncome);
            var marginalTax = CalculateMarginalTax(annualTaxableIncome, taxBracket);
            var monthlyIncomeTax = (taxBracket.AccumulatedTaxFromPreviousBracket + marginalTax) / Constants.MonthsInYear;

            return DecimalExtensionMethods.RoundValue(monthlyIncomeTax);
        }        

        public  decimal CalculateMarginalTax(decimal annualTaxableIncome, TaxBracket taxBracket)
        {
            var marginalTaxableAmount = CalculateMarginalTaxableAmount(annualTaxableIncome, taxBracket);
            return marginalTaxableAmount * taxBracket.MarginalTaxRate;
        }

        private  decimal CalculateMarginalTaxableAmount(decimal annualTaxableIncome, TaxBracket taxBracket)
        {
            return (annualTaxableIncome - taxBracket.IncomeThreshold);
        }

        public TaxBracket GetTaxBracket(decimal annualTaxableIncome)
        {
            if (!Validator.IsValidValue(annualTaxableIncome))
            {
                throw new System.Exception("Yearly income cannot be less than 0");
            }
            return TaxTableGenerator.TaxTableData.Single(x => Validator.IsValidTaxTableItem(annualTaxableIncome, x.MinThreshold, x.MaxThreshold)).IncomeTaxBracket;
        }

    }
}
