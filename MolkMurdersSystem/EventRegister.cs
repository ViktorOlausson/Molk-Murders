﻿using MolkMurdersSystem.Conditions;
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
            Events.Add(new PlainEvent("%PLAYER1% gick vilse i skogen i exakt två timmar."));
            Events.Add(new PlainEvent("%PLAYER1% missade bussen precis och fick vänta en timme."));
            Events.Add(new PlainEvent("%PLAYER1% fastnade i en while loop."));
            Events.Add(new PlainEvent("%PLAYER1% stod mest omkring alldeles ensam."));
            Events.Add(new PlainEvent("%PLAYER1% fastnade hos optikern."));
            Events.Add(new PlainEvent("%PLAYER1% trasslade in sig i sina hörlurskablar och kunde inte komma loss."));
            Events.Add(new PlainEvent("%PLAYER1% ville hellre lära sig ett nytt språk, danska kanske?."));
            Events.Add(new PlainEvent("%PLAYER1% sprang och gömde sig i en buske."));
            Events.Add(new PlainEvent("%PLAYER1% fick en snilleblixt."));
            Events.Add(new PlainEvent("%PLAYER1% fick en tindermatchning och sprang på date istället."));
            Events.Add(new PlainEvent("%PLAYER1% blev arg och hungrig på samma gång"));


            // Condition tests
            Events.Add(new PlainEvent("%PLAYER1% hoppade ner från ett flygplan och hamnade på arenan.") { Conditions = [new IsFirstRoundCondition()] });
            Events.Add(new PlainEvent("%PLAYER1% vaknade och fann sig själv i mitten av arenan.") { Conditions = [new IsFirstRoundCondition()] });
            Events.Add(new PlainEvent("%PLAYER1% använde sig av en uråldrig besvärjelse och hamnade på arenan.") { Conditions = [new IsFirstRoundCondition()] });
            Events.Add(new PlainEvent("%PLAYER1% gick vilse när han skulle till hemköp och gick rätt in på arenan.") { Conditions = [new IsFirstRoundCondition()] });


            // RandomPlainEvent tests
            Events.Add(new RandomPlainEvent(
                [
                    "%PLAYER1% mådde lite lustigt och utbrast \"Zoop!!!\"",
                    "%PLAYER1% kände 'the randoms' och sa  \"Blingo!!!\"",
                    "%PLAYER1% visste precis vad han skulle göra och sa \"Kazoops!!!\"",
                ]
                ));

            // "Tragic accident" tests
            Events.Add(new TragicAccidentEvent("%PLAYER1% slog i tån och dog, våldsamt."));
            Events.Add(new TragicAccidentEvent("%PLAYER1% blev hotad med kniv av %PLAYER1%, ramlade och bröt nacken."));
            Events.Add(new TragicAccidentEvent("%PLAYER1% trampade på en landmina, woops."));
            Events.Add(new TragicAccidentEvent("%PLAYER1% försökte jonglera motorsågar, gick inte riktigt som planerat."));
            Events.Add(new TragicAccidentEvent("%PLAYER1% fick trots extrema odds en meteor i skallen."));
            Events.Add(new TragicAccidentEvent("%PLAYER1% ville praktiskt lära sig hur seppuku gick till."));
            Events.Add(new TragicAccidentEvent("%PLAYER1% försökte lära sig hur doxygen fungerar."));
            Events.Add(new TragicAccidentEvent("%PLAYER1% fick en fiskmås i ögat"));

            // The Mörder of Mölk Mörders
            Events.Add(new CharacterKillsCharacterEvent("%PLAYER1% tyckte det var dags att %PLAYER2% mötte sitt öde."));

        }

        // TODO: Function to help add multiple events with the same conditions

    }
}
