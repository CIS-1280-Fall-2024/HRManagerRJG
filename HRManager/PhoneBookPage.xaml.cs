using HRManager.Models;
using HRManager.Services;

namespace HRManager;

public partial class PhoneBookPage : ContentPage
{
	private EmployeeService employeeService;

	public PhoneBookPage()
	{
		InitializeComponent();
		PhoneBook phoneBook = new PhoneBook();
		employeeService = new EmployeeService();
		foreach (Employee employee in employeeService.Employees)
		{
			phoneBook.PhoneBookEntries.Add(employee);
		}
		PhoneBookLabel.Text = phoneBook.GetPhoneBook();
	}
}