using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem {
    public abstract class GameEvent {
        public required List<IEventCondition> Conditions;
        public required int Priority;
        public required EventType Type;

        public enum EventType {
            Regular,
            Death,
            ItemPickup
        }

        public GameEvent() {

        }

        public virtual string Execute(EventData data) {
            // This is where logic would go...

            return "This is a default message.";
        }

        public virtual bool MeetsConditions() {
            return true;
        }
    }
}
