namespace HRManager.Models
{
    public class SalaryEmployee:Employee
    {
        public SalaryEmployee(int? empNum, string? firstName, string? lastName, decimal HourlyRate) : base(empNum, firstName, lastName)
        {
            Salary = 30000;
        }

        public SalaryEmployee():this(0, "tbd", "tbd", 30000M)
        {                
        }

        public decimal Salary { get; set; }

        public override string PaySummary
        {
            get
            {
                return $"Hourly employee {FirstName} {LastName} is owed {Salary/24:C} for the week.";
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Salary Employee";
        }
    }
}
