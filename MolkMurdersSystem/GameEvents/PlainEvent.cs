using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem.GameEvents {
    internal class PlainEvent : GameEvent {

        private string text = "";
        public PlainEvent(string text) {
            this.text = text;
        }

        public override EventData Execute(Character character) {
            return new EventData(text, [character]);
        }

    }
}
