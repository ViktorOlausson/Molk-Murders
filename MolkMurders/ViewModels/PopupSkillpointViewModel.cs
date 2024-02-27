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

        // Time for repetitive code #DRY
        private int iq = 0;
        private int str = 0;
        private int def = 0;
        private int agi = 0;
        public int IQ {
            get { return iq; }
            set { if (iq != value) { iq = value; OnPropertyChanged(); if (entry != null) entry.IQ = value; } }
        }
        public int STR {
            get { return str; }
            set { if (str != value) { str = value; OnPropertyChanged(); } }
        }
        public int DEF {
            get { return def; }
            set { if (def != value) { def = value; OnPropertyChanged(); } }
        }
        public int AGI {
            get { return agi; }
            set { if (agi != value) { agi = value; OnPropertyChanged(); } }
        }

        public PopupSkillpointViewModel() { }

        private CharacterEntryData? entry;

        public void UpdateStats(CharacterEntryData entry) {
			//Trace.WriteLine("This popup was just born!");
            CharacterName = entry.Name;
            IQ = entry.IQ; STR = entry.STR; DEF = entry.DEF; AGI = entry.AGI;
            this.entry = entry;
        }



	}
}
