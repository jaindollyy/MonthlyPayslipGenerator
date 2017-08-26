
using MonthlyPayslip.Calculator.Helper;
using MonthlyPayslip.Calculator.IncomeTax;

namespace MonthlyPayslip.Calculator.Payslip
{
    public class PayslipCalculator
    {     
        public PayslipInfo Calculate(PayslipInput payslipInput)
        {
            TaxCalculator taxCalculator = new TaxCalculator();

            var salary = payslipInput.Salary;
            var grossIncome = DecimalExtensionMethods.RoundValue(CalculateMonthlyTaxableIncomeFrom(salary));
            var incomeTax = taxCalculator.CalculateMonthlyPayableIncomeTax(salary);

            return new PayslipInfo(payslipInput.Employee,
                                   payslipInput.PayPeriod,
                                   payslipInput.SuperRate,
                                   grossIncome,
                                   incomeTax,
                                   grossIncome - incomeTax,
           DecimalExtensionMethods.RoundValue(grossIncome * payslipInput.SuperRate));
        }

        private decimal CalculateMonthlyTaxableIncomeFrom(decimal annualTaxableIncome)
        {
            const int monthsInAYear = 12;
            return (annualTaxableIncome / monthsInAYear);
        }
    }
}
