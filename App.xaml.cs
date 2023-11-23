using Inventory_maui.Data;

namespace Inventory_maui
{
    public partial class App : Application
    {
        public static DatabaseContext DatabaseContext { get; set; }
        public App(DatabaseContext databaseContext)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            DatabaseContext = databaseContext;
        }
    }
}