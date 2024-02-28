using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem.Conditions {
    public class IsNotAloneCondition : IEventCondition {
        public bool Check(Character character) {
            int amount = 0;
            foreach (Character c in Main.CurrentGame.Characters) {
                if (c != character && c.State == Character.LivingState.Alive) {
                    amount++;
                }
            }
            if (amount > 0) {
                return true;
            } else {
                return false;
            }
        }
    }
}
