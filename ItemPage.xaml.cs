using Inventory_maui.WinUI;

namespace Inventory_maui;

public partial class ItemPage : ContentPage
{
	public ItemPage()
	{
        InitializeComponent();
	}

    private void MainPage(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
    private void Additem(object sender, EventArgs e)
    {
        try
        {
            Item item = new Item();
            item.ProductionCost = 0;
            item.Price = 0;
            item.Quantity = 0;
            item.Name = "this is an item ";
            App.DatabaseContext.Add(item);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    private void SetItem(object sender, EventArgs e)
    {
        string text = App.DatabaseContext.GetAllitems()[0].Name;
        textfield.Text = text;
    }
}