using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using MolkMurders.ViewModels;
using MolkMurders.Views;

namespace MolkMurders
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Låter oss skriva saker till konsolen
            builder.Logging.AddDebug();

            // ViewModels
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            // En Transient förnyas varje gång man går in i den.
            // Kanske användbart när man ändrar karaktärer?
            builder.Services.AddTransient<GameplayPage>();
            builder.Services.AddTransient<GameplayViewModel>();

            builder.Services.AddSingleton<SetupPage>();
            builder.Services.AddSingleton<SetupPageViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
