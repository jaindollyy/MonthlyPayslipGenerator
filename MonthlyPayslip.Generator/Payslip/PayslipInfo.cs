using MonthlyPayslip.Calculator.Entities;

namespace MonthlyPayslip.Calculator.Payslip
{
    public class PayslipInfo: IPayslipInfo
    {
        public string PayPeriod { get;  }
        public Employee Employee { get; }
        public decimal GrossIncome { get; }
        public decimal NetIncome { get; }
        public decimal IncomeTax { get; }
        public decimal SuperRate { get; }
        public decimal SuperAmount { get; }

        public PayslipInfo(Employee employee, string payPeriod, decimal superRate, decimal grossIncome, decimal incomeTax,decimal netIncome, decimal superAmount)
        {
            Employee = employee;
            GrossIncome = grossIncome;
            IncomeTax = incomeTax;
            SuperRate = superRate;
            PayPeriod = payPeriod;
            NetIncome = netIncome;
            SuperAmount = superAmount;            
        }   

      
    }
}
