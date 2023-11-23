using Inventory_maui.Data;
using Microsoft.Extensions.Logging;

namespace Inventory_maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                });

#if DEBUG
		builder.Logging.AddDebug();
#endif
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "items.db");
            builder.Services.AddSingleton(s =>
            ActivatorUtilities.CreateInstance<DatabaseContext>(s, dbPath));
            return builder.Build();
        }
    }
}