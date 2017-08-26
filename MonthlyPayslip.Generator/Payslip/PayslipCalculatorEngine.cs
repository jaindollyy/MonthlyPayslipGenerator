namespace MonthlyPayslip.Calculator.Payslip
{
    public class PayslipCalculatorEngine
    {
        private static PayslipInput payslipInput;
        private static PayslipInfo payslipInfo;

        public static string GetPayslip(string input)
        {
            var inputProcessor = new InputProcessor();
            var payslipGenerator = new PayslipCalculator();
            var outputProcessor = new OutputProcessor();

            //InputProcessor will split the required Input from string 
            payslipInput = inputProcessor.Process(input);

            //Payslip Generator internally will calculate tax and create tax table to prepare payslip
            payslipInfo = payslipGenerator.Calculate(payslipInput);

            //OutputProcessor will join the output in string
            return outputProcessor.Process(payslipInfo);
        }

    }
}
