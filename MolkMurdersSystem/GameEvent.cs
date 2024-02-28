using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem {
    public abstract class GameEvent {
        // TODO: Make properties out of these
        private IEventCondition[] conditions;
        public IEventCondition[] Conditions {
            get => conditions;
            set => conditions = value;
        }
        public int Priority;

        public GameEvent() { }

        public virtual EventData Execute(Character character) {
            // This is where logic would go...
            return new EventData("This is a default message.", [character]); // Often, multiple characters are involved.
        }

        public virtual bool MeetsConditions(Character character) {
            if (Conditions != null) {
                foreach (IEventCondition condition in Conditions) {
                    if (condition.Check(character) == false) return false;
                }
            }
            return true;
        }
    }
}
