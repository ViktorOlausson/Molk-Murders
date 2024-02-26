using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem {
    public class Game {

        public List<Character> Characters = new List<Character>();

        public Game() {
            Characters.Add(new Character());
        }
    }
}
