using TextProcessor.ApplicationLogic.Services.TextProcessors;

namespace TextProcessor.UnitTests.Services.TextProcessors
{
    public class DuplicateCharacterCheckProcessorTests
    {
        private DuplicateCharacterCheckProcessor _duplicateCharacterCheckProcessor;

        [SetUp]
        public void Setup()
        {
            _duplicateCharacterCheckProcessor = new DuplicateCharacterCheckProcessor();
        }

        [Test]
        [TestCase("I like eating apples", "Found the following duplicates: ileap")]
        public void Process_DuplicatesFound_ReturnsFoundDuplicateCharacters(string text, string expectedResult)
        {
            var result = _duplicateCharacterCheckProcessor.Process(text);
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("abcd4", "No duplicate values were found")]
        public void Process_DuplicatesNotFound_ReturnsNoDuplicateCharactersFoundMessage(string text, string expectedResult)
        {
            var result = _duplicateCharacterCheckProcessor.Process(text);
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
