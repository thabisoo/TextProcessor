using TextProcessor.ApplicationLogic.Services.TextProcessorService.Interfaces;
using TextProcessor.DI;
using TextProcessor.Helpers;

namespace TextProcessor
{
    class Program
    {
        private static readonly IServiceProvider _container = ContainerBuilder.Build();
        private static readonly ITextProcessorService _textProcessorService = (ITextProcessorService)_container.GetService(typeof(ITextProcessorService));

        static void Main(string[] args)
        {
            Console.WriteLine(ConsoleMessages.ENTER_TEXT_MESSAGE);
            var text = Console.ReadLine();

            Console.WriteLine(ConsoleMessages.ENTER_OPERATIONS_MESSAGE);
            var operations = Console.ReadLine();

            var response = _textProcessorService.ProcessText(operations.ToCharArray(), text);

            foreach (var result in response)
            {
                Console.WriteLine(result);
            }
        }
    }
}
