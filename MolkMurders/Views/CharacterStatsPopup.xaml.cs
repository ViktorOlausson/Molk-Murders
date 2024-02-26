using CommunityToolkit.Maui.Views;
using MolkMurders.ViewModels;

namespace MolkMurders.Views
{
    public partial class CharacterStatsPopup : Popup
    {
        private int iq = 0;
        private int strength = 0;
        private int defense = 0;
        private int agility = 0;

        private readonly string availablePointsStr = "Tillgängliga poäng: ";
        private readonly int maxSkillPoint = 20;
        private int skillAmountUsed = 0;
        private int remainingAmount = 20;

        public CharacterStatsPopup()
        {
            InitializeComponent();

            iqPoints.Text = iq.ToString();
            Strength.Text = strength.ToString();
            Defense.Text = defense.ToString();
            Agility.Text = agility.ToString();

            remainingAmount = maxSkillPoint - skillAmountUsed;
            skillPointsAmount.Text = availablePointsStr + remainingAmount.ToString();

            // Adding the event handler to the constructor
            ProfilePictureButton.Clicked += ProfilePictureButton_Clicked;
        }

        private void CloseBtn_Clicked(object sender, EventArgs e)
        {
            Close();
        }

        private void PlusBtn_Clicked_iq(object sender, EventArgs e)
        {
            IncreaseSkill(ref iq, ref skillAmountUsed, ref remainingAmount, iqPoints);
        }

        private void MinusBtn_Clicked_iq(object sender, EventArgs e)
        {
            DecreaseSkill(ref iq, ref skillAmountUsed, ref remainingAmount, iqPoints);
        }

        private void MinusBtn_Clicked_strength(object sender, EventArgs e)
        {
            DecreaseSkill(ref strength, ref skillAmountUsed, ref remainingAmount, Strength);
        }

        private void PlusBtn_Clicked_strength(object sender, EventArgs e)
        {
            IncreaseSkill(ref strength, ref skillAmountUsed, ref remainingAmount, Strength);
        }

        private void MinusBtn_Clicked_defense(object sender, EventArgs e)
        {
            DecreaseSkill(ref defense, ref skillAmountUsed, ref remainingAmount, Defense);
        }

        private void PlusBtn_Clicked_defense(object sender, EventArgs e)
        {
            IncreaseSkill(ref defense, ref skillAmountUsed, ref remainingAmount, Defense);
        }

        private void MinusBtn_Clicked_agility(object sender, EventArgs e)
        {
            DecreaseSkill(ref agility, ref skillAmountUsed, ref remainingAmount, Agility);
        }

        private void PlusBtn_Clicked_agility(object sender, EventArgs e)
        {
            IncreaseSkill(ref agility, ref skillAmountUsed, ref remainingAmount, Agility);
        }

        private void DecreaseSkill(ref int skill, ref int skillAmountUsed, ref int remainingAmount, Label skillPointsLabel)
        {
            if (skillAmountUsed > 0 && skill > 0)
            {
                skill--;
                skillAmountUsed--;
                remainingAmount++;
                skillPointsLabel.Text = skill.ToString();
                skillPointsAmount.Text = availablePointsStr + remainingAmount.ToString();
            }
        }

        private void IncreaseSkill(ref int skill, ref int skillAmountUsed, ref int remainingAmount, Label skillPointsLabel)
        {
            if (skillAmountUsed < 20 && skill < 20)
            {
                skill++;
                skillAmountUsed++;
                remainingAmount--;
                skillPointsLabel.Text = skill.ToString();
                skillPointsAmount.Text = availablePointsStr + remainingAmount.ToString();
            }
        }

        // Event handler för profilbildclick
        private async void ProfilePictureButton_Clicked(object? sender, EventArgs e)
        {
            var result = await FilePicker.PickAsync(new PickOptions
            {
                FileTypes = FilePickerFileType.Images,
                PickerTitle = "Select Profile Picture",
            });

            if (result != null)
            {
                // Imagebutton source
                ProfilePictureButton.Source = new FileImageSource { File = result.FullPath };
            }
        }
    }
}
