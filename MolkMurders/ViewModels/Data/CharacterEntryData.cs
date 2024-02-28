using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurders.ViewModels.Data {
    public class CharacterEntryData : BindableObject {
        private string name = "Steve";

        private int availablePoints = 20;
        public int AvailablePoints { get => availablePoints; set { availablePoints = value; } }

        public string Name {
            get => name;
            set {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        private string imagePath = "steve.png";
        public string ImagePath {
            get => imagePath;
            set {
                imagePath = value;
                OnPropertyChanged(nameof(ImagePath));
            }
        }

        private int iq;
        public int IQ {
            get => iq;
            set {
                if (iq != value) {
                    iq = value;
                    OnPropertyChanged();
                }
            }
        }

        private int str;
        public int STR {
            get => str;
            set {
                if (str != value) {
                    str = value;
                    OnPropertyChanged();
                }
            }
        }

        private int def;
        public int DEF {
            get => def;
            set {
                if (def != value) {
                    def = value;
                    OnPropertyChanged();
                }
            }
        }

        private int agi;
        public int AGI {
            get => agi;
            set {
                if (agi != value) {
                    agi = value;
                    OnPropertyChanged();
                }
            }
        }

    }
}
