namespace Inventory_maui;

public partial class PasswordPage : ContentPage
{
    String TempPass = "123";
    public PasswordPage()
	{
		InitializeComponent();
	}
    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = PasswordEntry.Text;
    }
    void OnEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }
    private void Access(object sender, EventArgs e)
    {
        if(PasswordEntry.Text==TempPass)
        {
            Navigation.PushAsync(new AdminPage());
        }
    }
}