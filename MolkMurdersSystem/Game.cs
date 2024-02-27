using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem {
    public class Game {

        public List<GameRound> Rounds = new List<GameRound>();
        public List<Character> Characters = new List<Character>();

        // This class is created when a new game starts (After pressing the Start Game button)

        public Game() {
            Characters.Add(new Character("Dingo")); // Temporary.
            Characters.Add(new Character("Wingo"));
            Characters.Add(new Character("Tingo"));
            Characters.Add(new Character("Zingo"));
            Characters.Add(new Character("Greg"));
        }

        public void NewRound() {
            GameRound round = new GameRound();
            round.Play();
            Rounds.Add(round);
        }
    }
}
