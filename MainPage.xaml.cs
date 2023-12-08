using Microsoft.Maui;

namespace Inventory_maui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void itemPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ItemPage());
        }

        private void adminpanel(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PasswordPage());
        }
    }
}