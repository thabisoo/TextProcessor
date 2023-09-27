using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextProcessor.ApplicationLogic.Services.TextProcessors;

namespace TextProcessor.UnitTests.Services.TextProcessors
{
    public class VowelCounterProcessorTests
    {
        private VowelCounterProcessor _vowelCounterProcessor;

        [SetUp]
        public void Setup()
        {
            _vowelCounterProcessor = new VowelCounterProcessor();

        }

        [Test]
        [TestCase("I like eating apples", "The number of vowels is 3")]
        public void Process_VowelsFound_ReturnsVowelsFoundInText(string text, string expectedResult)
        {
            var result = _vowelCounterProcessor.Process(text);
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("jkl kkjh", "No vowels were found")]
        public void Process_VowelsNotFound_ReturnsVowelsNotFoundMessage(string text, string expectedResult)
        {
            var result = _vowelCounterProcessor.Process(text);
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
