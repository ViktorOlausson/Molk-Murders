using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem {
    public class EventData {
        public string Text;
        public Character[] InvolvedCharacters;

        public EventType Type = EventType.Regular;
        public enum EventType {
            Regular,
            Death,
            ItemPickup
        }

        public EventData(string text, Character[] involvedCharacters) {
            Text = text;
            InvolvedCharacters = involvedCharacters;
        }
        public EventData(string text, Character[] involvedCharacters, EventType type) {
            Text = text;
            Type = type;
            InvolvedCharacters = involvedCharacters;
        }

    }
}
