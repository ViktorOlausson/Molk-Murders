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

		async void SkillPoints_Clicked(object sender, EventArgs e)
		{
			await Shell.Current.ShowPopupAsync(nameof(CharacterStatsPopup));
			//this.ShowPopup(new CharacterStatsPopup());
		}
	}
}
