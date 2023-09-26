using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextProcessor.ApplicationLogic.Enums;
using TextProcessor.ApplicationLogic.Services.TextProcessors.Interfaces;

namespace TextProcessor.ApplicationLogic.Services.TextProcessors
{
    public class InvalidTextProcessor : ITextProcessor
    {
        public ProcessType ProcessType => ProcessType.INVALID_OPERATION;

        public string Process(string text)
        {
            return $"Invalid operation. Cannot process '{text}'.";
        }
    }
}
