using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem.Helpers {
    public class ExtraFunctions {

        public static Character PickRandomAliveCharacter(Character self) {
            List<Character> alive = new List<Character>();
            foreach (Character c in Main.CurrentGame.Characters) {
                if (c.State == Character.LivingState.Alive && c != self) {
                    alive.Add(c);
                }
            }
            if (alive.Count == 0) {
                return null;
            }

            int r = Main.Random.Next(alive.Count);
            return alive[r];
        }

    }
}
