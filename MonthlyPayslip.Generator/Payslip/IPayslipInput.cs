using MonthlyPayslip.Calculator.Entities;

namespace MonthlyPayslip.Calculator.Payslip
{
    interface IPayslipInput
    {
       Employee Employee { get;  }
        string PayPeriod { get; }
        decimal Salary { get;  }
        decimal SuperRate { get;  }
    }
}
