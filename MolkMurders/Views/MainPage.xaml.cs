using MolkMurders.ViewModels;
﻿using CommunityToolkit.Maui.Views;
using MolkMurders.Views;

namespace MolkMurders
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
            this.ShowPopup(new music());
        }

        public void soundButtonClicked(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new Settings());
            this.ShowPopup(new music());
        }

        async void OnStartButtonClicked(object sender, EventArgs e) {
            await Shell.Current.GoToAsync(nameof(SetupPage), false);
        }

        public void settingsButtonClicked(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new Settings());
            this.ShowPopup(new Settings());
        }

        private void exitButtonClicked(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        // this.ShowPopup(new CharacterStatsPopup());
        // this.ShowPopup(new Settings());
    }
}
