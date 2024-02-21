using CommunityToolkit.Maui.Views;
using MolkMurders.Views;


namespace MolkMurders
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

		private void StatsPopupBtn_Clicked(object sender, EventArgs e)
		{
            this.ShowPopup(new CharacterStatsPopup());
		}
	}

}
