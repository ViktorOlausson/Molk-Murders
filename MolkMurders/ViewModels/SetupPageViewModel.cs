using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using MolkMurders.Views;
using MolkMurdersSystem;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MolkMurders.ViewModels {
    public partial class SetupPageViewModel : ObservableObject {

        public ICommand EditCharacterCommand { get; private set; }
        public ICommand DeleteCharacterCommand { get; private set; }

        public SetupPageViewModel(IPopupService popupService) {
            EditCharacterCommand = new Command<string>(EditCharacter);
            DeleteCharacterCommand = new Command<string>(DeleteCharacter);
            this.popupService = popupService;
        }

        private readonly IPopupService popupService;

        private void EditCharacter(string parameter) {
            Trace.WriteLine($"Den här knappen har en parameter, och den är {parameter}!");
            CharacterProfile chosen_profile = Profiles[Int32.Parse(parameter)];

            this.popupService.ShowPopup<PopupSkillpointViewModel>(
                onPresenting: viewModel => viewModel.UpdateStats(chosen_profile)
                );
        }

        private void DeleteCharacter(string parameter) {

        }

        public static List<CharacterProfile> Profiles = new List<CharacterProfile>();

    }
}
