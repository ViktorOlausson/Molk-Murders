using MolkMurdersSystem.Conditions;
using MolkMurdersSystem.Helpers;
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

        public override bool MeetsConditions(Character character) {
            IEventCondition cond = new IsNotAloneCondition();
            if(!cond.Check(character)) {
                return false;
            }
            return base.MeetsConditions(character);
        }

        public override EventData Execute(Character character) {
            Character random = ExtraFunctions.PickRandomAliveCharacter(character);
            random.Kill();
            
            return new EventData(text, [character, random]);
        }

    }
}
