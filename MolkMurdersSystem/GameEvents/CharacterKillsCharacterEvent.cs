using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem.GameEvents {
    internal class CharacterKillsCharacterEvent : GameEvent {

        private string text = "";
        public CharacterKillsCharacterEvent(string text) {
            this.text = text;
        }

        public override EventData Execute(Character character) {
            // TODO.
            
            return new EventData(text, [character]);
        }

    }
}
