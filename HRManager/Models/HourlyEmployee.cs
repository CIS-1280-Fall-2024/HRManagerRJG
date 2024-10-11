namespace HRManager.Models
{
    /// <summary>
    /// Hourly employees have an hourly rate in addition
    /// to attributes provided by Employee class.
    /// </summary>
    public class HourlyEmployee:Employee
    {
        public HourlyEmployee(int? empNum, string? firstName, string? lastName,decimal HourlyRate):base(empNum,firstName,lastName)
        {
            HourlyRate = 15.0M;
        }

        public HourlyEmployee():this(0, "tbd", "tbd", 15.0M)
        {
        }

        private decimal hourlyRate;

        public decimal HourlyRate
        {
            get { return hourlyRate; }
            set 
            {
                if (value< 0)
                {
                    throw new InvalidHourlyRateException();
                }
                hourlyRate = value; 
            }
        }


        public override string PaySummary
        {
            get
            {
                return $"Hourly employee {FirstName} {LastName} is owed {hourlyRate * 40.0M:C} for the week.";
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Hourly Employee";
        }
    }
}
