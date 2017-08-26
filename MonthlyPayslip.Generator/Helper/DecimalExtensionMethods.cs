using System;

namespace MonthlyPayslip.Calculator.Helper
{
   public static class DecimalExtensionMethods
    {        
        public static decimal RoundValue(decimal value)
        {
            return Math.Round(value,0, MidpointRounding.AwayFromZero);
        }      
    }
}
