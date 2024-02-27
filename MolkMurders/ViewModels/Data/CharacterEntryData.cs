using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurders.ViewModels.Data {
    public class CharacterEntryData : BindableObject {
        private string name = "Steve";
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
    }
}
