using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextProcessor.ApplicationLogic.Enums;
using TextProcessor.ApplicationLogic.Helplers.ResponseMessages.Services.TextProcessors;
using TextProcessor.ApplicationLogic.Services.TextProcessors.Interfaces;

namespace TextProcessor.ApplicationLogic.Services.TextProcessors
{
    public class DuplicateCharacterCheckProcessor : ITextProcessor
    {
        public ProcessType ProcessType => ProcessType.DUPLICATE_CHECKER;

        public string Process(string text)
        {
            text = text.ToLower();
            Dictionary<char, int> characters = new();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ') continue;

                if (characters.ContainsKey(text[i]))
                {
                    characters[text[i]]++;
                    continue;
                }

                characters.Add(text[i], 1);
            }

            var response = string.Join("", characters.Where(i => i.Value > 1).Select(i => i.Key).ToArray());

            if (response.Length == 0)
            {
                return DuplicateCharacterResponseMessages.NO_DUPLICATES;
            }

            return $"{DuplicateCharacterResponseMessages.DUPLICATES_FOUND}{response}";
        }
    }
}
