using CommunityToolkit.Maui.Views;
using MolkMurders.ViewModels;
using System.Diagnostics;

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

	private void OnAddCharacterButtonClicked(object sender, EventArgs e) {
		BuildCharacterBox();
	}

	private void BuildCharacterBox() {

		HorizontalStackLayout stack = new HorizontalStackLayout {
			Spacing = 10,
			Children = {
				new Image {
					Source="steve.png" // TODO: Add proper character portrait path here.
				},
				new VerticalStackLayout {
					Spacing = 10,
					Children = {
						new HorizontalStackLayout {
							Spacing = 10,
							Children = {
								new Entry {
									Placeholder = "Insert name...",
									Text = "Some character",
									WidthRequest = 200,
									HorizontalOptions = LayoutOptions.Start,
								},
								new Button {
									Text = "Edit Character",
									HorizontalOptions = LayoutOptions.End,
									Command = ((SetupPageViewModel)BindingContext).EditCharacterCommand,
									CommandParameter="WOAH!"
								}
							}
						}
					}
				}
			}
		};

		Frame frame = new Frame {
			BackgroundColor = Colors.AliceBlue,
			HeightRequest=200,
			VerticalOptions = LayoutOptions.Start,
			Content = stack
		};

		characterEntries.Add(frame);
	}

	private void SkillPointsPop(object sender, EventArgs e)
	{
		this.ShowPopup(new CharacterStatsPopup());
	}
}