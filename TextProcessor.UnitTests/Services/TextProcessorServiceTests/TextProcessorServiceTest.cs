using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextProcessor.ApplicationLogic.Services.TextProcessors;
using TextProcessor.ApplicationLogic.Services.TextProcessors.Interfaces;
using TextProcessor.ApplicationLogic.Services.TextProcessorService;

namespace TextProcessor.UnitTests.Services.TextProcessorServiceTests
{
    public class TextProcessorServiceTest
    {
        private TextProcessorService _textProcessorService;

        [SetUp]
        public void Setup()
        {
            _textProcessorService = new TextProcessorService(new List<ITextProcessor>
            {
                new DuplicateCharacterCheckProcessor(),
                new VowelCounterProcessor(),
                new VowelVersusNonVowelProcessor(),
                new InvalidTextProcessor()
            });
        }

        [Test]
        [TestCase(new char[] { '1', '2' }, "I like to eat apples", new string[] { "Found the following duplicates: iletap", "The number of vowels is 4" })]
        [TestCase(new char[] { '1' }, "I like to eat apples", new string[] { "Found the following duplicates: iletap" })]
        [TestCase(new char[] { '2', '3' }, "I like to eat apples", new string[] { "The number of vowels is 4", "The text has an equal amount of vowels and non vowels" })]
        [TestCase(new char[] { '3', '4' }, "I like to eat apples", new string[] { "The text has an equal amount of vowels and non vowels", "Invalid operation. Cannot process 'I like to eat apples'." })]
        public void ProcessText_WhenCalled_ReturnsAListOfOperationsMessages(char[] operations, string text, string[] expectedResult)
        {
            var result = _textProcessorService.ProcessText(operations, text);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
