using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextProcessor.ApplicationLogic.Services.TextProcessors;

namespace TextProcessor.UnitTests.Services.TextProcessorTests
{
    public class VowelVersusNonVowelProcessorTests
    {
        private VowelVersusNonVowelProcessor _vowelVersusNonVowelProcessor;

        [SetUp]
        public void Setup()
        {
            _vowelVersusNonVowelProcessor = new VowelVersusNonVowelProcessor();
        }

        [Test]
        [TestCase("I eat", "The text has more vowels than non vowels")]
        public void Process_MoreVowelsThanNonVowels_ReturnsMoreVowelsThanNonVowelsMessage(string text, string expectedResult)
        {
            var result = _vowelVersusNonVowelProcessor.Process(text);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("that dog", "The text has more non vowels than vowels")]
        public void Process_MoreNonVowelsThanVowels_ReturnsMoreNonVowelsThanVowelsMessage(string text, string expectedResult)
        {
            var result = _vowelVersusNonVowelProcessor.Process(text);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("3 a", "The text has an equal amount of vowels and non vowels")]
        public void Process_VowelsAndNonVowelsAreEqual_ReturnsVowelsAndNonVowelsAreEqualMessage(string text, string expectedResult)
        {
            var result = _vowelVersusNonVowelProcessor.Process(text);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
