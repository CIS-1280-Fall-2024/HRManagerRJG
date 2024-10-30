using HRManager.Models;

namespace HRManager.Services
{
    public class DepartmentsService
    {
        public List<Department> Departments { get; set; };

        public DepartmentsService() 
        {
            Department dep = new Department("Sales Department");
            Departments = new List<Department>();
            Departments.Add(dep);                
        }
    }
}
