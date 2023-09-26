using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessor.ApplicationLogic.Helplers.ResponseMessages.Services.TextProcessors
{
    public static class VowelVersusNonVowelResponseMessages
    {
        public const string ARE_EQUAL = "The text has an equal amount of vowels and non vowels";

        public const string MORE_VOWELS = "The text has more vowels than non vowels";

        public const string MORE_NON_VOWELS = "The text has more non vowels than vowels";
    }
}
