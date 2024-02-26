using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem {
    public class EventData {
        public string Text;
        public Character[] InvolvedCharacters;

        public EventData(string text, Character[] involvedCharacters) {
            Text = text;
            InvolvedCharacters = involvedCharacters;
        }

    }
}
