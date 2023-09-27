namespace TextProcessor.ApplicationLogic.Services.TextProcessorService.Interfaces
{
    public interface ITextProcessorService
    {
        public List<string> ProcessText(char[] operations, string text);
    }
}
