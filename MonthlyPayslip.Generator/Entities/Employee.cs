namespace MonthlyPayslip.Calculator.Entities
{
    public class Employee
    {
        private string LastName { get; }
        private string FirstName { get; }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FullName => FirstName + " " + LastName;
    }
}
