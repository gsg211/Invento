using Microsoft.Maui;

namespace Inventory_maui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        private void ItemPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ItemPage());
        }
    }
}