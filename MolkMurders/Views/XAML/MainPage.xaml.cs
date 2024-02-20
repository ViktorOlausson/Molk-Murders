using MolkMurdersSystem;

namespace MolkMurders
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            var label1 = new Label {
                Text = "Label 1",
                FontSize = 20
            };

            var stackLayout = new StackLayout {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Spacing = 10
            };

            // Add initial content to the stackLayout
            stackLayout.Children.Add(label1);

            // Button to add more content
            var addButton = new Button {
                Text = "Add Label",
                Margin = new Thickness(0, 10, 0, 0)
            };

            addButton.Clicked += (sender, e) => {
                // Add new content to the stackLayout
                stackLayout.Children.Add(new Label {
                    Text = "Label 2",
                    FontSize = 20
                });
            };

            // Add the stackLayout and the addButton to the content of the page
            Content = new StackLayout {
                Children = { stackLayout, addButton },
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Padding = new Thickness(20)
            };
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
    }

}
