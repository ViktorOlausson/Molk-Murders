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
        }

        async void OnStartButtonClicked(object sender, EventArgs e) {
            await Shell.Current.GoToAsync(nameof(GameplayPage), false);
        }
        
		    // this.ShowPopup(new CharacterStatsPopup());
		    // this.ShowPopup(new Settings());
    }
}
