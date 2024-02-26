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
        }

        // TODO: Function to help add multiple events with the same conditions

    }
}
