using HRManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Services
{
    public class EmployeeService
    {
        public List<Employee> Employees { get; set; }

        public EmployeeService() 
        {
            SalaryEmployee emp = new SalaryEmployee();
            emp.EmpNum = 1;
            emp.FirstName = "Steve";
            emp.LastName = "Jobs";
            emp.Email = "steve.jobs@apple.com";
            emp.Phone = "555-1212";

            HourlyEmployee hourEmp = new HourlyEmployee();
            hourEmp.EmpNum = 2;
            hourEmp.FirstName = "Bill";
            hourEmp.LastName = "Gates";
            hourEmp.Email = "bill.gates@microsoft.com";
            hourEmp.Phone = "555-1313";
            hourEmp.HourlyRate = 20.00M;

            Employees = new List<Employee>();
            Employees.Add(emp);
            Employees.Add(hourEmp);
        }
    }
}
