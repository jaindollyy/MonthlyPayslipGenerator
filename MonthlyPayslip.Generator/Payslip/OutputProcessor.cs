using MonthlyPayslip.Calculator.Helper;

namespace MonthlyPayslip.Calculator.Payslip
{
    public class OutputProcessor
    {
        public string Process(PayslipInfo payslipInfo)
        {
            var result = new[]
            {
                payslipInfo.Employee.FullName,
                payslipInfo.PayPeriod,
                payslipInfo.GrossIncome.ToString(),
                payslipInfo.IncomeTax.ToString(),
                payslipInfo.NetIncome.ToString(),
                payslipInfo.SuperAmount.ToString()
            };
            
            return string.Join(Constants.separator.ToString(), result);
        } 
    }
}