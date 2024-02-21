using MolkMurders.ViewModels;
using MolkMurders.Views;

namespace MolkMurders
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        async void OnStartButtonClicked(object sender, EventArgs e) {
            await Shell.Current.GoToAsync(nameof(GameplayPage));
        }

    }

}
