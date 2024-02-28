using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem {
    public class CharacterProfile {

        public string Name = "Steve";
        public string Path = "steve.png";
        public int id = 0;

        public int Iq; public int Strength; public int Defense; public int Agility;

        public CharacterProfile() { }

        public CharacterProfile(string name, string path) {
            Name = name; Path = path;
        }

        public void SaveToDisk() {
            // TODO.
        }

    }
}
