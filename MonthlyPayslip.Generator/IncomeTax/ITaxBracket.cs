
namespace MonthlyPayslip.Calculator.IncomeTax
{
    interface ITaxBracket
    {
        decimal AccumulatedTaxFromPreviousBracket { get; }
        decimal MarginalTaxRate { get; }
        decimal IncomeThreshold { get; }

    }
}
