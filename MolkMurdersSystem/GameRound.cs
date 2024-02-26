using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem {
    public class GameRound {
        public int Round;


        // Generates 
        public void Generate() {
            // For each character, do stuff.
            if (Main.CurrentGame == null) return;

            foreach(Character c in Main.CurrentGame.Characters) {

            }

            // Return an array of EventData or something, I don't know.
        }

    }
}
