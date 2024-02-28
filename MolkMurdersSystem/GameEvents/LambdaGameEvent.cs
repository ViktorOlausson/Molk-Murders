using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem.GameEvents {
    public class LambdaGameEvent : GameEvent {
        private Func<Character, EventData> _func;
        public LambdaGameEvent(Func<Character, EventData> func) {
            _func = func;
        }
        public override EventData Execute(Character character) {
            return _func(character);
        }
    }
}
