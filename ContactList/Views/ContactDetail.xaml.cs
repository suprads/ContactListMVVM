namespace ContactList.Views;

public partial class ContactDetail : ContentPage
{
	public ContactDetail()
	{
		InitializeComponent();
	}
    private void BackButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}