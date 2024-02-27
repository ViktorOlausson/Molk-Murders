using CommunityToolkit.Mvvm.ComponentModel;
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

        private string name;

        public string CharacterName {
            get { return name; }
            set {
                if (name != value) {
                    name = value;
                    OnPropertyChanged(nameof(CharacterName));
                }
            }
        }

        public PopupSkillpointViewModel()
		{
            //CharacterName = "Heck"; // Funkar
        }

        public void UpdateStats(CharacterProfile profile) { // TODO: Pass through character profile...
			Trace.WriteLine("This popup was just born!");
            CharacterName = "It works!";
        }

	}
}
