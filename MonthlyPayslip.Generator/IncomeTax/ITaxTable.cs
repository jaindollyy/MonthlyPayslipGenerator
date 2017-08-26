
namespace MonthlyPayslip.Calculator.IncomeTax
{
    interface ITaxTable
    {
        decimal MinThreshold { get; }
        decimal MaxThreshold { get;  }
        TaxBracket IncomeTaxBracket { get; }     
    }
}
