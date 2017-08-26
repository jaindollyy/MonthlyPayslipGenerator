using MonthlyPayslip.Calculator.Entities;
using MonthlyPayslip.Calculator.Helper;

namespace MonthlyPayslip.Calculator.Payslip
{
    public class InputProcessor
    {
        public PayslipInput Process(string input)
        {            
                var values = input.Split(Constants.separator);

                var employeeFirstName = values[0];
                var employeeLastName = values[1];
                var employeeDetails = new Employee(employeeFirstName, employeeLastName);

                var salary = Converter.StringToDecimal(values[2]);
                var superRate = Converter.StringPercentageToDecimal(values[3]);
                var payPeriod = values[4];

                return new PayslipInput(employeeDetails, payPeriod, salary, superRate);

         }
    }
}