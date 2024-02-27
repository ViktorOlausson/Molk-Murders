using CommunityToolkit.Mvvm.ComponentModel;
using MolkMurders.ViewModels.Data;
using MolkMurdersSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurders.ViewModels
{
	public partial class PopupSkillpointViewModel : ObservableObject
	{

        private string name = "Steve";

        public string CharacterName {
            get { return name; }
            set {
                if (name != value) {
                    name = value;
                    OnPropertyChanged(nameof(CharacterName));
                    if (entry != null) {
                        entry.Name = value;
                    }
                }
            }
        }

        public PopupSkillpointViewModel() { }

        private CharacterEntryData? entry;

        public void UpdateStats(CharacterEntryData entry) {
			//Trace.WriteLine("This popup was just born!");
            CharacterName = entry.Name;
            this.entry = entry;
        }

	}
}
