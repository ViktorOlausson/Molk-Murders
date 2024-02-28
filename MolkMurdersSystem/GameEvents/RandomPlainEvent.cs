using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem.GameEvents {
    internal class RandomPlainEvent : GameEvent {

        private string[] texts;
        public RandomPlainEvent(string[] texts) {
            this.texts = texts;
        }

        public override EventData Execute(Character character) {
            int i = Main.Random.Next(texts.Length);
            string str = texts[i];
            return new EventData(str, [character]);
        }

    }
}
