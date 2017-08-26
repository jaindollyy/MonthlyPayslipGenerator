namespace MonthlyPayslip.Calculator.IncomeTax
{
    public class TaxBracket : ITaxBracket
    {
        public decimal AccumulatedTaxFromPreviousBracket { get; }
        public decimal MarginalTaxRate { get; }
        public decimal IncomeThreshold { get; }

        public TaxBracket(
            decimal accumulatedTaxFromPreviousBracket,
            decimal marginalTaxRate,
            decimal incomeThreshold)
        {
            AccumulatedTaxFromPreviousBracket = accumulatedTaxFromPreviousBracket;
            MarginalTaxRate = marginalTaxRate;
            IncomeThreshold = incomeThreshold;
        }       

    }
}
