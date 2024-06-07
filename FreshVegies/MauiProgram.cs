

namespace FreshVeggies
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                 .UseMauiCommunityToolkit()
                .UseMauiCommunityToolkitMarkup()
                 .ConfigurePages()
                .ConfigureServices()
                .ConfigureHandlers()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        public static MauiAppBuilder ConfigurePages(this MauiAppBuilder builder)
        {

            //account Views


            // other views
            builder.Services.AddTransient<BuyPage, BuyViewModel>();
            //builder.Services.AddTransient<CartPage, CartViewModel>();
            //builder.Services.AddTransient<OrdersPage, OrdersViewModel>();
            //builder.Services.AddTransient<SettingsPage, SettingsViewModel>();


            return builder;
        }



        public static MauiAppBuilder ConfigureServices(this MauiAppBuilder builder)
        {
            //App Services
            builder.Services.AddSingleton<IRealmService, RealmService>();


            // Other Services
            builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
            return builder;


        }

        public static MauiAppBuilder ConfigureHandlers(this MauiAppBuilder builder)
        {
            return builder.ConfigureMauiHandlers(handlers =>
            {



            });


        }
    }
}
