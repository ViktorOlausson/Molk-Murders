using Microsoft.Maui.Controls.Shapes;
using MolkMurdersSystem;

namespace MolkMurders
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        int someNumber = 0;

        public MainPage()
        {
            InitializeComponent();

            var addButton = new Button {
                Text = "This button was added directly from MainPage.xaml.cs",
                Margin = new Thickness(0, 10, 0, 0)
            };

            ScrollView scrollView = (ScrollView)Content;
            VerticalStackLayout stackLayout = (VerticalStackLayout)scrollView.Content;

            addButton.Clicked += (sender, e) => {
                /*
                stackLayout.Children.Add(new Label {
                    Text = $"Label {++someNumber}",
                    FontSize = 20
                });
                */
                CreateHappeningThing();
            };

            stackLayout.Children.Add(addButton);
        }

        

        private void OnCounterClicked(object sender, EventArgs e)
        {

            CharacterProfile profile = new CharacterProfile();


            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void CreateHappeningThing() {

            CharacterProfile profile = new CharacterProfile();

            Image image = new Image {
                Source = profile.PortraitPath,
                HeightRequest = 64,
            };

            AbsoluteLayout al = new AbsoluteLayout {

            };
            al.Add(image);
            al.Add(new Image {
                Source = profile.PortraitPath,
                HeightRequest = 32,
                TranslationX = 38, TranslationY = 38,
            });

            Frame frame = new Frame {
                WidthRequest = 300,
                HeightRequest = 100,
            };

            HorizontalStackLayout hz = new HorizontalStackLayout {
                Children = {
                    al,
                    new Label {
                        Text = "It's Steeeeeve!\nAnd baby Steeeeeve!",
                    }
                },
                Spacing = 10,
            };

            frame.Content = hz;

            ScrollView scrollView = (ScrollView)Content;
            VerticalStackLayout stackLayout = (VerticalStackLayout)scrollView.Content;

            stackLayout.Children.Add(frame);

        }

    }

}
