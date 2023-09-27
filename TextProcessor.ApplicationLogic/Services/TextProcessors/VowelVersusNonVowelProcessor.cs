using TextProcessor.ApplicationLogic.Enums;
using TextProcessor.ApplicationLogic.Helplers.ResponseMessages.Services.TextProcessors;
using TextProcessor.ApplicationLogic.Helplers.VowelHelpers;
using TextProcessor.ApplicationLogic.Services.TextProcessors.Interfaces;

namespace TextProcessor.ApplicationLogic.Services.TextProcessors
{
    public class VowelVersusNonVowelProcessor : ITextProcessor
    {
        public ProcessType ProcessType => ProcessType.VOWEL_VERSUS_NON_VOWEL;

        public string Process(string text)
        {
            text = text.ToLower();

            int vowels = 0;
            int  nonVowels = 0;
            Dictionary<char, char> vowelsMap = VowelsHelper.GetVowels();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ') continue;

                if (vowelsMap.ContainsKey(text[i]))
                {
                    vowels++;
                    continue;
                }
                
                nonVowels++;
            }

            if(vowels == nonVowels)
            {
                return VowelVersusNonVowelResponseMessages.ARE_EQUAL;
            }

            return vowels > nonVowels ? VowelVersusNonVowelResponseMessages.MORE_VOWELS 
                : VowelVersusNonVowelResponseMessages.MORE_NON_VOWELS;
        }
    }
}
