using TextProcessor.ApplicationLogic.Enums;
using TextProcessor.ApplicationLogic.Helplers.EnumHeplers;
using TextProcessor.ApplicationLogic.Services.TextProcessors.Interfaces;
using TextProcessor.ApplicationLogic.Services.TextProcessorService.Interfaces;

namespace TextProcessor.ApplicationLogic.Services.TextProcessorService
{
    public class TextProcessorService : ITextProcessorService
    {
        private readonly Dictionary<ProcessType, ITextProcessor> _textProcessors = new();

        public TextProcessorService(IEnumerable<ITextProcessor> textProcessors)
        {
            foreach (var textProcessor in textProcessors)
            {
                _textProcessors.Add(textProcessor.ProcessType, textProcessor);
            }
        }

        public List<string> ProcessText(char[] operations, string text)
        {
            List<string> response = new();

            foreach (var operation in operations)
            {
                var processType = EnumValueFromDescriptionHelper.GetValueFromDescription<ProcessType>(operation.ToString());
                if (_textProcessors.TryGetValue(processType, out var textProcessor))
                {
                    response.Add(textProcessor.Process(text));
                }
            }

            return response;
        }
    }
}
