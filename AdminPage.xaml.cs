namespace Inventory_maui;

public partial class AdminPage : ContentPage
{
	public AdminPage()
	{
		InitializeComponent();
	}
    private void MainPage(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
    private void addItem(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddItemPage());
    }
}