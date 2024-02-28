using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkMurdersSystem.Helpers {
    public static class StringFormatter {

        /// <summary>
        /// Formats strings, replacing tags with character or item names.
        /// </summary>
        public static string CharacterFormat(string str, EventData data) {
            StringBuilder builder = new StringBuilder(str);
            for (int i = 0; i < data.InvolvedCharacters.Length; i++) {
                string name = data.InvolvedCharacters[i].profile.Name;
                builder.Replace($"%PLAYER{i+1}%", name == "" ? "Den namnlösa" : name);
            }
            return builder.ToString();
        }

    }
}
