using System;
using MonthlyPayslip.Calculator.Helper;

namespace MonthlyPayslip.Calculator.IncomeTax
{
    public class TaxTable : ITaxTable 
    {
        public  decimal MinThreshold { get; }
        public  decimal MaxThreshold { get; }
        public  TaxBracket IncomeTaxBracket { get; }


        public TaxTable(decimal minThreshold, decimal maxThreshold, TaxBracket incomeTaxBracket)
        {
            MinThreshold = minThreshold;
            MaxThreshold = maxThreshold;
            IncomeTaxBracket = incomeTaxBracket;
        }

        public static TaxTable Add(decimal minThreshold,
                                                     decimal maxThreshold,
                                                     decimal accumulatedTaxFromPreviousBracket,
                                                     decimal marginalTaxRate)
        {
            if (!Validator.IsBetween(minThreshold, maxThreshold)) {
                throw new System.Exception("Min value cannot be greater than or equal to max value");
            }
            
            var incomeThreshold = CalculateIncomeThreshold(minThreshold);
            var taxBracket = new TaxBracket(accumulatedTaxFromPreviousBracket, marginalTaxRate, incomeThreshold);
            var taxTableItem = new TaxTable(minThreshold, maxThreshold, taxBracket);

            return taxTableItem;
        }      
               
      
        private static decimal CalculateIncomeThreshold(decimal minThreshold)
        {
            return (minThreshold - 1 > 0) ? minThreshold - 1 : 0;
        }
    }
}
