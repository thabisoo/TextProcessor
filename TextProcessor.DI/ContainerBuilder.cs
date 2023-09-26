using Microsoft.Extensions.DependencyInjection;
using System;
using TextProcessor.ApplicationLogic.Services.TextProcessors;
using TextProcessor.ApplicationLogic.Services.TextProcessors.Interfaces;
using TextProcessor.ApplicationLogic.Services.TextProcessorService;
using TextProcessor.ApplicationLogic.Services.TextProcessorService.Interfaces;

namespace TextProcessor.DI
{
    public static class ContainerBuilder
    {
        public static IServiceProvider Build()
        {
            var container = new ServiceCollection();

            container.AddTransient<ITextProcessor, DuplicateCharacterCheckProcessor>();
            container.AddTransient<ITextProcessor, VowelCounterProcessor>();
            container.AddTransient<ITextProcessor, VowelVersusNonVowelProcessor>();
            container.AddTransient<ITextProcessor, InvalidTextProcessor>();
            container.AddTransient<ITextProcessorService, TextProcessorService>();

            return container.BuildServiceProvider();
        }
    }
}
