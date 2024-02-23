using MolkMurders.ViewModels;
using MolkMurdersSystem;

namespace MolkMurders.Views;

public partial class GameplayPage : ContentPage
{
	public GameplayPage(GameplayViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;

		BuildEventBox(new EventData("Damn.", new Character[] {new Character(), new Character(), new Character { State = Character.LivingState.Dead } }));

	}

	private void BuildEventBox(EventData data) {

		HorizontalStackLayout portraits = new HorizontalStackLayout {
            HeightRequest = 100, HorizontalOptions = LayoutOptions.Center, Spacing = 15,
        };

		foreach(Character c in data.InvolvedCharacters) {
			var portrait = new AbsoluteLayout {
				Children = {
					new Image {
						Source = c.GetCharacterImagePath(),
						HeightRequest = 100
					}
				}
			};
            
			if(c.State == Character.LivingState.Dead) { // Character is dead
                portrait.Children.Add(new Image {
                    Source = "littleskull.png",
                    TranslationX = 60, TranslationY = 60,
                    HeightRequest = 48
                });
            } else if (c.HeldItem != null) { // Character has item
                portrait.Children.Add(new Image {
                    Source = "steve.png", // TODO: Get item texture
                    TranslationX = 60, TranslationY = 60,
                    HeightRequest = 48
                });
            }

            if (c.HeldItem == null) { // TODO: Make a skull if dead.
				
			}

            portraits.Children.Add(portrait);
        }

		Frame frame = new Frame {
			MinimumHeightRequest = 200,
			Content = new VerticalStackLayout {
				Spacing = 10,
				Children = {
					portraits,
					new HorizontalStackLayout {
						HorizontalOptions = LayoutOptions.Center,
						Children = {
							new Label {
								HorizontalOptions = LayoutOptions.Center, LineBreakMode = LineBreakMode.WordWrap, MaxLines = 3, HorizontalTextAlignment = TextAlignment.Center,
								WidthRequest=400,
								Text= data.Text
							}
						}
					}
				}
			}
		};

		eventsList.Add(frame);
	}
}