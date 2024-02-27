using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using MolkMurders.ViewModels.Data;
using MolkMurders.Views;
using MolkMurdersSystem;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MolkMurders.ViewModels {
    public partial class SetupPageViewModel : ObservableObject {

        public ICommand EditCharacterCommand => new Command<CharacterEntryData>(EditCharacter);

        public SetupPageViewModel(IPopupService popupService) {
            this.popupService = popupService;
        }

        private readonly IPopupService popupService;

        private void EditCharacter(CharacterEntryData entry) {

            this.popupService.ShowPopup<PopupSkillpointViewModel>(
                onPresenting: viewModel => viewModel.UpdateStats(entry)
                );
        }

        private ObservableCollection<CharacterEntryData> entries = new ObservableCollection<CharacterEntryData>();
        public ObservableCollection<CharacterEntryData> Entries { get => entries; set {
                entries = value;
                OnPropertyChanged(nameof(Entries));
            } }

        public ICommand AddCharacterCommand => new Command(AddCharacter);
        private void AddCharacter() {
            Entries.Add(new CharacterEntryData { Name = "Främling" });
        }

        public ICommand DeleteCharacterCommand => new Command<CharacterEntryData>(DeleteCharacter);
        private void DeleteCharacter(CharacterEntryData entry) {
            Entries.Remove(entry);
        }

        public ICommand GameStartCommand => new Command<string>(GameStart);

        async void GameStart(string arg) {

            List<CharacterProfile> profiles = new List<CharacterProfile>();

            foreach (CharacterEntryData entry in Entries) {
                CharacterProfile profile = new CharacterProfile();
                profile.Name = entry.Name;
                profile.Path = entry.ImagePath;
                profiles.Add(profile);
            }

            MolkMurdersSystem.Main.StartGame(profiles);
            await Shell.Current.GoToAsync(nameof(GameplayPage), false);
        }

    }
}
