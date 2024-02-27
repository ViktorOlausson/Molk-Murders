using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem.Conditions {
    public class IsFirstRoundCondition : IEventCondition {
        public bool Check(Character character) {
            if (Main.CurrentGame.Rounds.Count == 0) return true; // Round is 0 before it has been completed and added to the list of rounds.
            return false;
        }
    }
}
