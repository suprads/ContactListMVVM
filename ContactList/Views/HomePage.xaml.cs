using ContactList.Models.ViewModels;

namespace ContactList.Views;

public partial class HomePage : ContentPage
{
    private ContactListViewModel contactsViewModel;
    public HomePage()
	{
		InitializeComponent();
		contactsViewModel = new ContactListViewModel();
        BindingContext = contactsViewModel;

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var contactList = new ContactsList();
        contactList.BindingContext =contactsViewModel;
        Navigation.PushAsync(contactList);
    }
}