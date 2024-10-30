using HRManager.Services;

namespace HRManager;

public partial class PhoneBookPage : ContentPage
{
	public PhoneBookPage()
	{
		InitializeComponent();
		PhoneBook phoneBook = new PhoneBook();
	}
}