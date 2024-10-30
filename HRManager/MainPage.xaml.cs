using HRManager.Models;
using HRManager.Services;

namespace HRManager
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        private EmployeeService employeeService;

        public MainPage()
        {
            InitializeComponent();
           
            try
            {
                employeeService = new EmployeeService();

                foreach (Employee e in employeeService.Employees)
                {
                    if (e is HourlyEmployee)
                    {
                        HourlyEmployee unboxedEmp = (HourlyEmployee)e;
                        lblList.Text += $"\n{unboxedEmp} earns {unboxedEmp.HourlyRate} an hour.";
                    }
                    else
                    {
                        lblList.Text += $"\n{e} does not have an Hourly rate.";
                    }
                }
            }
            catch (Exception ex) 
            {
                ErrorLabel.Text = $"Error! {ex.Message}";
            }
        }
    }
}
