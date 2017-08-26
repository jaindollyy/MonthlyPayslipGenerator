
using MonthlyPayslip.Calculator.Entities;

namespace MonthlyPayslip.Calculator.Payslip
{ 
    public class PayslipInput : IPayslipInput
    {
        public Employee Employee { get; }
        public string PayPeriod { get; }
        public decimal Salary { get;  }
        public decimal SuperRate { get; }

        public PayslipInput(Employee employee, string payPeriod,decimal salary, decimal superRate)
        {
            Employee = employee;
            PayPeriod = payPeriod;
            Salary = salary;
            SuperRate = superRate;
        }

        
    
    }
}
