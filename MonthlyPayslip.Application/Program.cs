using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MonthlyPayslip.Calculator.Helper;
using MonthlyPayslip.Calculator.Payslip;

namespace MonthlyPayslip.Application
{
    public class Program
    {
        public static List<string> payslips = new List<string> { };
        static void Main(string[] args)
        {
            string Directory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            bool InputFileFound = false;
            string[] Inputs = null;

            try
            {
                Inputs = File.ReadAllLines(GetFilePath(true));
                InputFileFound = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Input file - " + ex.Message.ToString());
                InputFileFound = false;
            }
            if (InputFileFound)
            {          
                foreach (var input in Inputs)
                {                  
                    payslips.Add(PayslipCalculatorEngine.GetPayslip(input));
                }
                if (payslips.Count > 0)
                {
                    WriteOutputToFile();
                    Console.WriteLine("Output file is available at " + GetFilePath(false));
                }
                else
                {
                    Console.WriteLine("No inputs found to generate payslip");
                }

            }
            Console.ReadLine();           
        }


        static string GetFilePath(Boolean isInput = false)
        {
            var homePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filePath = Path.Combine(homePath, isInput ? Constants.InputFileName : Constants.OutputFileName);
            return filePath;
        }

        public static void WriteOutputToFile()
        {
            string Directory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string OutPutFile = @"" + Directory;

            using (FileStream fs = File.OpenWrite((GetFilePath(false))))
            {
                foreach (var payslip in payslips)
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(payslip);
                    fs.Write(info, 0, info.Length);
                    byte[] newline = Encoding.ASCII.GetBytes(Environment.NewLine);
                    fs.Write(newline, 0, newline.Length);
                }
            }
        }
    }

}