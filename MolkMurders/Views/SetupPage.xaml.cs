using MolkMurders.ViewModels;

namespace MolkMurders.Views;

public partial class SetupPage : ContentPage
{
	public SetupPage(SetupPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	// TODO: Dynamically create new character entries when 

    async void OnStartButtonClicked(object sender, EventArgs e) {
        await Shell.Current.GoToAsync(nameof(GameplayPage), false);
    }
}