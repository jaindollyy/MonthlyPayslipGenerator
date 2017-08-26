using System;
using System.Text.RegularExpressions;

namespace MonthlyPayslip.Calculator.Helper
{
    public class Converter
    {
        public static decimal StringPercentageToDecimal(string input)
        {
            const string pattern = @"^(\d*.+\d*)%$";
            var result = Regex.Match(input, pattern);
            return Convert.ToDecimal(result.Groups[1].Value) * 0.01m;
           
        }

        public static decimal StringToDecimal(string input)
        {
            return Convert.ToDecimal(input);
        }
    }
}
