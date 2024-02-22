using CommunityToolkit.Maui.Views;
using MolkMurders.ViewModels;

namespace MolkMurders.Views;

public partial class CharacterStatsPopup : Popup
{
	// iqPoints.text
	// skillPointsAmount
	private int iq = 0;
	private int strength = 0;
	private int defense = 0;
	private int agility = 0;
	private int maxSkillPoint = 20;
	private int skillPoint = 0;

	public CharacterStatsPopup(PopupSkillpointViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		string pointsToApply = "Tillgängliga poäng: ";
		// int iq = 0;
		int skillAmount = 0;
		int remainingAmount = maxSkillPoint - skillAmount;
		iqPoints.Text = iq.ToString(); 
		Strength.Text = strength.ToString();
		Defense.Text = defense.ToString();
		Agility.Text = agility.ToString();
		skillPointsAmount.Text = pointsToApply + remainingAmount.ToString();
	}
	private void CloseBtn_Clicked(object sender, EventArgs e)
	{
		Close();
	}
	private void PlusBtn_Clicked_iq(object sender, EventArgs e)
	{
		iq++;
		iqPoints.Text = iq.ToString();
	}
	private void MinusBtn_Clicked_iq(object sender, EventArgs e)
	{
		iq--;
		iqPoints.Text = iq.ToString();
	}

	private void MinusBtn_Clicked_strength(object sender, EventArgs e)
	{
		strength--;
		Strength.Text = strength.ToString();
	}

	private void PlusBtn_Clicked_strength(object sender, EventArgs e)
	{
		strength++;
		Strength.Text = strength.ToString();
	}

	private void MinusBtn_Clicked_defense(object sender, EventArgs e)
	{
		defense--;
		Defense.Text = defense.ToString();
	}

	private void PlusBtn_Clicked_defense(object sender, EventArgs e)
	{
		defense++;
		Defense.Text = defense.ToString();
	}

	private void MinusBtn_Clicked_agility(object sender, EventArgs e)
	{
		agility--;
		Agility.Text = agility.ToString();
	}

	private void PlusBtn_Clicked_agility(object sender, EventArgs e)
	{
		agility++;
		Agility.Text = agility.ToString();
	}
}