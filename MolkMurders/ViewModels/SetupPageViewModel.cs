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
        
        public SetupPageViewModel(IPopupService popupService) {
            EditCharacterCommand = new Command<string>(EditCharacter);
            this.popupService = popupService;
        }

        private readonly IPopupService popupService;

        private void EditCharacter(string parameter) {
            Trace.WriteLine($"Den här knappen har en parameter, och den är {parameter}!");
            //Shell.Current.ShowPopup<PopupSkillpointViewModel>();
            this.popupService.ShowPopup<PopupSkillpointViewModel>();
        }

        public static List<CharacterProfile> Profiles = new List<CharacterProfile>();

    }
}
