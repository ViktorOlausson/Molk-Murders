using MolkMurdersSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem {
    public class GameRound {
        public int Round;

        public List<EventData> Events = new List<EventData>();

        public void Play() {
            if (Main.CurrentGame == null) return;
            List<Character> characters = new List<Character>(Main.CurrentGame.Characters); // Copy of the characters list.
            characters.Shuffle(); // Shuffle the list of characters, making the game more fair.

            foreach (Character character in characters) {
                if (character.State == Character.LivingState.Dead) break; // TODO: Make dead characters do simple actions...?
                List<GameEvent> choosable = new List<GameEvent>();
                foreach (GameEvent ev in EventRegister.Events) {
                    if (ev.MeetsConditions(character) == true) {
                        // Add to list of possible executions
                        choosable.Add(ev);
                    }
                }
                int n = Main.Random.Next(choosable.Count);
                GameEvent chosen = choosable[n];

                // EventData wasn't meant to be used like this, but we're doing it anyways. Oops.
                EventData data = chosen.Execute(character);
                Events.Add(data);
            
            }

            //Events.Add(new EventData("No way!", []));


            // TODO: Make system that allows skipping characters.


            // Return an array of EventData or something, I don't know.
        }

    }
}
