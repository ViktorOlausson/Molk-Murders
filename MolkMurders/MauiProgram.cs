using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using MolkMurders.ViewModels;
using MolkMurders.Views;
using MolkMurdersSystem;
using System.Diagnostics;

namespace MolkMurders
{
    public static class MauiProgram
    {

        public static string DataPath = "";

        public static MauiApp CreateMauiApp()
        {

            // MÖLK!
            Main.Init();

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

            // Initialize appdata directory
            string curFile = Path.Combine(AppContext.BaseDirectory, "Data/info.txt");
            Trace.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");


            // ViewModels
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            // En Transient förnyas varje gång man går in i den.
            // Kanske användbart när man ändrar karaktärer?
            builder.Services.AddTransient<GameplayPage>();
            builder.Services.AddTransient<GameplayViewModel>();

            builder.Services.AddSingleton<SetupPage>();
            builder.Services.AddSingleton<SetupPageViewModel>();

            builder.Services.AddTransientPopup<CharacterStatsPopup, PopupSkillpointViewModel>();

#if DEBUG
			builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
