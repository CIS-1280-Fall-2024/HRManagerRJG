using HRManager.Models;
using HRManager.Services;

namespace HRManager;

public partial class PhoneBookPage : ContentPage
{
	private EmployeeService employeeService;
	private DepartmentsService departmentsService;

	public PhoneBookPage()
	{
		InitializeComponent();
		PhoneBook phoneBook = new PhoneBook();
		employeeService = new EmployeeService();
		departmentsService = new DepartmentsService();

		foreach (Employee employee in employeeService.Employees)
		{
			phoneBook.PhoneBookEntries.Add(employee);
		}

		foreach (Department department in departmentsService.Departments)
		{
			phoneBook.PhoneBookEntries.Add(department);
		}

		PhoneBookLabel.Text = phoneBook.GetPhoneBook();
	}
}