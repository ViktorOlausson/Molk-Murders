using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem {
    public class Main {
        public static Game? CurrentGame = new Game();

        public static Random Random = new Random();

        public static void Init() {
            EventRegister.Register();
        }

        public static void StartGame() {
            CurrentGame = new Game();
            CurrentGame.NewRound();

        }

    }
}
