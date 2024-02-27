using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurders.ViewModels.Data {
    public class CharacterEntryData : BindableObject {
        private string name = "Steve";

        public int AvailablePoints { get; set; }

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
                name = value;
                OnPropertyChanged(nameof(ImagePath));
            }
        }

        private string statsText = "IQ: 0 - STR: 0 - DEF: 0 - AGI: 0";
        public string StatsText {
            get => statsText;
            set {
                statsText = value;
                OnPropertyChanged(nameof(StatsText));
            }
        }

        public int IQ = 0;
        public int STR = 0;
        public int DEF = 0;
        public int AGI = 0;

        public void SetStatsText() {
            StatsText = $"IQ: {IQ} - STR: {STR} - DEF: {DEF} - AGI: {AGI}";
        }

    }
}
