using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextProcessor.ApplicationLogic.Enums;
using TextProcessor.ApplicationLogic.Helplers.ResponseMessages.Services.TextProcessors;
using TextProcessor.ApplicationLogic.Helplers.VowelHelpers;
using TextProcessor.ApplicationLogic.Services.TextProcessors.Interfaces;

namespace TextProcessor.ApplicationLogic.Services.TextProcessors
{
    public class VowelCounterProcessor : ITextProcessor
    {
        public ProcessType ProcessType => ProcessType.VOWEL_COUNTER;

        public string Process(string text)
        {
            text = text.ToLower();

            int counter = 0;
            Dictionary<char, char> vowels = new();
            Dictionary<char, char> vowelsMap = VowelsHelper.GetVowels();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ') continue;

                if (vowelsMap.ContainsKey(text[i]) && vowels.ContainsKey(text[i])) continue;

                if (vowelsMap.ContainsKey(text[i]))
                {
                    vowels.Add(text[i], text[i]);
                    counter++;
                }
            }

            if(counter == 0)
            {
                return VowelCounterResponseMessages.NO_VOWELS;
            }

            return $"{VowelCounterResponseMessages.VOWELS_FOUND}{counter}";
        }
    }
}
