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
using System.Windows.Input;

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
            set { if (str != value) { str = value; OnPropertyChanged(); if (entry != null) entry.STR = value; } }
        }
        public int DEF {
            get { return def; }
            set { if (def != value) { def = value; OnPropertyChanged(); if (entry != null) entry.DEF = value; } }
        }
        public int AGI {
            get { return agi; }
            set { if (agi != value) { agi = value; OnPropertyChanged(); if (entry != null) entry.AGI = value; } }
        }

        private int availablePoints;
        public int AvailablePoints {
            get { return  availablePoints; }
            set { if(availablePoints != value) { availablePoints = value; OnPropertyChanged(); if (entry != null) entry.AvailablePoints = value; } }
        }

        public PopupSkillpointViewModel() { }

        private CharacterEntryData? entry;

        public void UpdateStats(CharacterEntryData entry) {
			//Trace.WriteLine("This popup was just born!");
            CharacterName = entry.Name;
            IQ = entry.IQ; STR = entry.STR; DEF = entry.DEF; AGI = entry.AGI;
            AvailablePoints = entry.AvailablePoints;
            this.entry = entry;
        }

        public ICommand ChangePointsCommand => new Command<string>(ChangePoints);
        private void ChangePoints(string param) {
            string sign = param.Substring(0, 1);
            string stat = param[1..]; // My friend just told me about this and I am going insane
            if (sign == "+") {
                if (entry != null && AvailablePoints > 0) {
                    switch (stat) { // There's definitely better solutions than this, but it works fine.
                        case "iq":
                                IQ++; AvailablePoints--;
                            break;
                        case "str":
                            STR++; AvailablePoints--;
                            break;
                        case "def":
                            DEF++; AvailablePoints--;
                            break;
                        case "agi":
                            AGI++; AvailablePoints--;
                            break;
                    }
                }
            }else if (sign == "-") {
                if(entry != null) {
                    switch (stat) {
                        case "iq":
                            if (IQ > 0) {
                                IQ--; AvailablePoints++;
                            }
                            break;
                        case "str":
                            if (STR > 0) {
                                STR--; AvailablePoints++;
                            }
                            break;
                        case "def":
                            if (DEF > 0) {
                                DEF--; AvailablePoints++;
                            }
                            break;
                        case "agi":
                            if (AGI > 0) {
                                AGI--; AvailablePoints++;
                            }
                            break;
                    }
                }
            
            }
        }

    }
}
