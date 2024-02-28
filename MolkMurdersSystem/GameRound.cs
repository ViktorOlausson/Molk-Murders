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

            int alive = 0; Character survivor = null;
            foreach (Character c in characters) {
                if(c.State == Character.LivingState.Alive) {
                    alive++;
                    survivor = c;
                }
            }

            if (alive == 0) {
                EventData endEvent = new EventData("Det verkar inte som att någon överlevde. Denna gång vinner döden.", [
                    new Character { HeldItem = new Item("pokal"), profile = new CharacterProfile("Döden", "death.png") } // Bild av döden: https://commons.wikimedia.org/wiki/File:The_death.svg
                    ]);
                Events.Add(endEvent);
                Main.CurrentGame.IsOver = true;
            }else if (alive == 1) {
                survivor.HeldItem = new Item("pokal");
                EventData endEvent = new EventData("%PLAYER1% verkar vara vinnaren av spelet! Grattis %PLAYER1%!", [survivor]);
                Events.Add(endEvent);
                Main.CurrentGame.IsOver = true;
            }

            List<GameEvent> chosenEvents = EventRegister.Events;
            if (Main.CurrentGame.IsOver) {
                chosenEvents = EventRegister.WinnerEvents;
            }

            foreach (Character character in characters) {
                if (character.State == Character.LivingState.Dead) continue; // TODO: Make dead characters do simple actions...?
                List<GameEvent> choosable = new List<GameEvent>();
                foreach (GameEvent ev in chosenEvents) {
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
        }

    }
}
