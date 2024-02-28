using CommunityToolkit.Maui.Views;
using MolkMurders.ViewModels;

namespace MolkMurders.Views
{
	public partial class CharacterStatsPopup : Popup {
		// iqPoints.text
		// skillPointsAmount
		// Skills to apply skillpoints to:
		private int iq = 0;
		private int strength = 0;
		private int defense = 0;
		private int agility = 0;

		private readonly string avaliblePointsStr = "Tillgängliga poäng: ";
		private readonly int maxSkillPoint = 20;
		private int skillAmountUsed = 0;
		private int remainingAmount = 20;
		public CharacterStatsPopup(PopupSkillpointViewModel vm) {
			InitializeComponent();
			BindingContext = vm;
			// Skillpoints text
			//iqPoints.Text = iq.ToString();
			//Strength.Text = strength.ToString();
			//Defense.Text = defense.ToString();
			//Agility.Text = agility.ToString();


			//remainingAmount = maxSkillPoint - skillAmountUsed;
			//skillPointsAmount.Text = avaliblePointsStr + remainingAmount.ToString();
		}
		private void CloseBtn_Clicked(object sender, EventArgs e) {
			Close();
		}
	}
}
