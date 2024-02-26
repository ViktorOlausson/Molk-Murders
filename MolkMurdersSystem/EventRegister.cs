using MolkMurdersSystem.Conditions;
using MolkMurdersSystem.GameEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem {
    public class EventRegister {

        public static List<GameEvent> Events = new List<GameEvent>();

        public static void Register() {
            // It would also be possible to make the text inside PlainEvent completely random. Priority would still matter.
            Events.Add(new PlainEvent("%PLAYER1% was hanging around all by himself."));
            Events.Add(new PlainEvent("%PLAYER1% got lost in the woods for 2 hours."));
            Events.Add(new PlainEvent("%PLAYER1% didn't catch the bus in time and had to wait for another hour."));
            Events.Add(new PlainEvent("%PLAYER1% got stuck in a while loop."));
            Events.Add(new PlainEvent("%PLAYER1% was hanging around all by himself."));

            // Condition tests
            Events.Add(new PlainEvent("%PLAYER1% fell down from a plane, landing in this arena.") { Conditions = [new IsFirstRoundCondition()] });
            Events.Add(new PlainEvent("%PLAYER1% woke up, finding himself in the middle of the arena.") { Conditions = [new IsFirstRoundCondition()] });

            // RandomPlainEvent tests
            Events.Add(new RandomPlainEvent(
                [
                    "%PLAYER1% felt kind of random and said \"Zoop!!!\"",
                    "%PLAYER1% was feeling the randoms and said \"Blingo!!!\"",
                    "%PLAYER1% knew what he had to do, and said \"Kazoops!!!\"",
                ]
                ));

            // "Tragic accident" tests
            Events.Add(new TragicAccidentEvent("%PLAYER1% stubbed his toe and died, violently."));

        }

        // TODO: Function to help add multiple events with the same conditions

    }
}
