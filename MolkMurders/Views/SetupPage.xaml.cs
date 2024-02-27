using CommunityToolkit.Maui.Views;
using MolkMurders.ViewModels;
using MolkMurdersSystem;
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

	/*
    async void OnStartButtonClicked(object sender, EventArgs e) {
		// Start game here.
		MolkMurdersSystem.Main.StartGame();
        await Shell.Current.GoToAsync(nameof(GameplayPage), false);
    }
	*/

	private void OnAddCharacterButtonClicked(object sender, EventArgs e) {
		/*
		CharacterProfile prof = new CharacterProfile();
		prof.Name = "Dingus";
		SetupPageViewModel.Profiles.Add(prof);
		BuildCharacterBox(prof);
		*/
	}

	private void BuildCharacterBox(CharacterProfile prof) {

		HorizontalStackLayout stack = new HorizontalStackLayout {
			Spacing = 10,
			Children = {
				new Image {
					Source = prof.Path
				},
				new VerticalStackLayout {
					Spacing = 10,
					Children = {
						new HorizontalStackLayout {
							Spacing = 10,
							Children = {
								new Entry {
									Placeholder = "Insert name...",
									Text = prof.Name,
									WidthRequest = 200,
									HorizontalOptions = LayoutOptions.Start,
								},
								new Button {
									Text = "Edit Character",
									HorizontalOptions = LayoutOptions.End,
									Command = ((SetupPageViewModel)BindingContext).EditCharacterCommand,
									CommandParameter="0" // TODO: Insert ID here
								},
								new Button {
									Text = "Delete Character",
									HorizontalOptions = LayoutOptions.End,
                                    Command = ((SetupPageViewModel)BindingContext).DeleteCharacterCommand,
                                    CommandParameter="WOAH!" // TODO: Insert ID here
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
		//CharacterStatsPopup popup = new CharacterStatsPopup();

		//this.ShowPopup(popup);
	}
}