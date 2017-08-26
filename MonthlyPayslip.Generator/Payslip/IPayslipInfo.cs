
using MonthlyPayslip.Calculator.Entities;

namespace MonthlyPayslip.Calculator.Payslip
{
    interface IPayslipInfo
    {
        string PayPeriod { get; }
        Employee Employee { get;  }
        decimal NetIncome { get; }
        decimal GrossIncome { get; }
        decimal IncomeTax { get; }
        decimal SuperRate { get; }
        decimal SuperAmount { get; }
    }
}
