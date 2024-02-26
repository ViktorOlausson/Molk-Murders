using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem.GameEvents {
    public class TragicAccidentEvent : GameEvent {

        private string text = "";
        public TragicAccidentEvent(string text) {
            this.text = text;
        }

        public override EventData Execute(Character character) {
            character.Kill(); // :-(
            return new EventData(text, [character]);
        }
    }
}
