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
            Events.Add(new PlainEvent("%PLAYER1% Gick vilse i skogen i exakt två timmar."));
            Events.Add(new PlainEvent("%PLAYER1% Missade bussen precis och fick vänta en timme."));
            Events.Add(new PlainEvent("%PLAYER1% Fastnade i en while loop."));
            Events.Add(new PlainEvent("%PLAYER1% Stod mest omkring alldeles ensam."));
            Events.Add(new PlainEvent("%PLAYER1% Fastnade hos optikern."));
            Events.Add(new PlainEvent("%PLAYER1% Trasslade in sig i sina hörlurskablar och kunde inte komma loss."));
            Events.Add(new PlainEvent("%PLAYER1% Ville hellre lära sig ett nytt språk, danska kanske?."));


            // Condition tests
            Events.Add(new PlainEvent("%PLAYER1% Hoppade ner från ett flygplan och hamnade på arenan.") { Conditions = [new IsFirstRoundCondition()] });
            Events.Add(new PlainEvent("%PLAYER1% Vaknade och fann sig själv i mitten av arenan.") { Conditions = [new IsFirstRoundCondition()] });
            Events.Add(new PlainEvent("%PLAYER1% Använde sig av en uråldrig besvärjelse och hamnade på arenan.") { Conditions = [new IsFirstRoundCondition()] });
            Events.Add(new PlainEvent("%PLAYER1% Gick vilse när han skulle till hemköp och gick rätt in på arenan.") { Conditions = [new IsFirstRoundCondition()] });


            // RandomPlainEvent tests
            Events.Add(new RandomPlainEvent(
                [
                    "%PLAYER1% Mådde lite lustigt och utbrast \"Zoop!!!\"",
                    "%PLAYER1% Kände 'the randoms' och sa  \"Blingo!!!\"",
                    "%PLAYER1% Visste precis vad han skulle göra och sa \"Kazoops!!!\"",
                ]
                ));

            // "Tragic accident" tests
            Events.Add(new TragicAccidentEvent("%PLAYER1% Slog i tån och dog, våldsamt."));
            Events.Add(new TragicAccidentEvent("%PLAYER1% Blev hotad med kniv av %PLAYER1%, ramlade och bröt nacken."));
            Events.Add(new TragicAccidentEvent("%PLAYER1% Trampade på en landmina, woops."));
            Events.Add(new TragicAccidentEvent("%PLAYER1% Försökte jonglera motorsågar, gick inte riktigt som planerat."));
            Events.Add(new TragicAccidentEvent("%PLAYER1% Fick trots extrema odds en meteor i skallen."));
            Events.Add(new TragicAccidentEvent("%PLAYER1% Ville praktiskt lära sig hur seppuku gick till."));
            Events.Add(new TragicAccidentEvent("%PLAYER1% Försökte lära sig hur doxygen fungerar."));


        }

        // TODO: Function to help add multiple events with the same conditions

    }
}
