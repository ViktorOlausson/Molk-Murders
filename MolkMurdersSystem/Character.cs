using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem {
    public class Character {

        public CharacterProfile profile = new CharacterProfile(); // TODO: Remove this value.
        public bool HasPlayedThisRound = false;

        public Item ?HeldItem = null;

        public enum LivingState {
            Alive, Dead
        }

        public LivingState State = LivingState.Alive;

        public Character() {

        }
        public Character(string name) { // For testing
            profile.Name = name;
        }

        public void Kill() {
            State = LivingState.Dead;
        }

        /// TODO: Return a fitting image path for the character depending on state.
        public string GetCharacterImagePath() {
            return profile.Path;
        }

    }
}
