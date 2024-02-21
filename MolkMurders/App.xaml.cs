using Microsoft.Maui.Controls;
using MolkMurders.Views;

namespace MolkMurders
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

    }
}
