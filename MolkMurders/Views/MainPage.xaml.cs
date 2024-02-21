using MolkMurders.Views;

namespace MolkMurders
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        async void NextPageNaviation(System.Object sender, System.EventArgs e) {
            await Navigation.PushAsync(new Gameplay(), true);
        }

    }

}
