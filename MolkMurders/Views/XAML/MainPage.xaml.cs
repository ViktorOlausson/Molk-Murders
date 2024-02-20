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
                stackLayout.Children.Add(new Label {
                    Text = $"Label {++someNumber}",
                    FontSize = 20
                });
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
    }

}
