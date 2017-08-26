using System;
using System.Text.RegularExpressions;

namespace MonthlyPayslip.Calculator.Helper
{
    public static class Validator
    {
        public static bool IsValidValue(decimal value)
        {
          return (value > 0);
        }

        public static bool IsValidTaxTableItem(decimal annualTaxableIncome, decimal minThreshold , decimal maxThreshold)
        {
            return (annualTaxableIncome > minThreshold && annualTaxableIncome < maxThreshold);       
        }

        public static bool IsBetween(decimal min, decimal max)
        {
            return min >= 0 && min <= max;
        }       
    }

}
