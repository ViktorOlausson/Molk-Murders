using MolkMurders.Views;

namespace MolkMurders
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(GameplayPage), typeof(GameplayPage));
            Routing.RegisterRoute(nameof(SetupPage), typeof(SetupPage));
        }
    }
}
