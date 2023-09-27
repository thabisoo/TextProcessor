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
