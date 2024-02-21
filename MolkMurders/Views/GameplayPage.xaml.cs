using MolkMurders.ViewModels;

namespace MolkMurders.Views;

public partial class GameplayPage : ContentPage
{
	public GameplayPage(GameplayViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}