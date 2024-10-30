using HRManager.Interfaces;

namespace HRManager.Models
{
    /// <summary>
    /// Base class that represents any kind of employee
    /// </summary>
    public class Employee:IPhoneBookItem
    {
        public Employee(int? empNum, string? firstName, string? lastName)
        {
            EmpNum = empNum;
            FirstName = firstName;
            LastName = lastName;
        }

        public Employee():this(0,"tbd","tbd")
        {
            
        }

        public int? EmpNum { get; set; }
        public string? FirstName {  get; set; }
        public string? LastName { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual string PaySummary
        {
            get
            {
                return $"No pay info for {FirstName} {LastName}.";
            }
        }

        public override string ToString()
        {
            return $"{EmpNum} {FirstName} {LastName}";
        }

        public string GetContactSummary()
        {
            return FirstName + " " + LastName + "\n" +
                    "Phone: " + Phone + "\n" +
                    "Email: " + Email;
        }
    }
}
