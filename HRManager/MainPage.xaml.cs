using HRManager.Models;

namespace HRManager
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        Employee emp;
        HourlyEmployee hourEmp;

        public MainPage()
        {
            InitializeComponent();
            emp = new Employee();
            emp.EmpNum = 1;
            emp.FirstName = "Steve";
            emp.LastName = "Jobs";

            hourEmp = new HourlyEmployee();
            hourEmp.EmpNum = 2;
            hourEmp.FirstName = "Bill";
            hourEmp.LastName = "Gates";
            try
            {
                hourEmp.HourlyRate = -20.00M;


                Employee polymorphEmployee = hourEmp; //Child class object assigned into variable declared using parent class
                                                      //HourlyEmployee cantWork = emp; <--doesn't work

                lblEmp1.Text = $"emp {emp}\nGetHashCode {emp.GetHashCode()}\nGetType {emp.GetType()}\nToString {emp.ToString()}";
                lblEmp2.Text = $"hourEmp {hourEmp}\nGetHashCode {hourEmp.GetHashCode()}\nGetType {hourEmp.GetType()}\nToString {hourEmp.ToString()}";
                lblEmp3.Text = $"{polymorphEmployee}\nGetHashCode {polymorphEmployee.GetHashCode()}\nGetType {polymorphEmployee.GetType()}\nToString {polymorphEmployee.ToString()}";

                //Boxing
                object aThing = emp;
                lblAThing.Text = $"{aThing}";

                //Unboxing
                if (aThing is HourlyEmployee)
                {
                    HourlyEmployee unboxedEmp = (HourlyEmployee)aThing;
                    lblUnboxedEmp.Text = $"{unboxedEmp} earns {unboxedEmp.HourlyRate} an hour.";
                }
                else
                {
                    lblUnboxedEmp.Text = $"{aThing} does not have an Hourly rate.";
                }

                List<Employee> empList = new List<Employee>();
                empList.Add(emp);
                empList.Add(hourEmp);
                empList.Add(new HourlyEmployee());
                empList.Add(new Employee());

                foreach (Employee e in empList)
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
                lblEmp1.Text = $"Error! {ex.Message}";
            }
        }
    }
}
