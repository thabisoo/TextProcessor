using TextProcessor.ApplicationLogic.Services.TextProcessors;

namespace TextProcessor.UnitTests.Services.TextProcessors
{
    public class InvalidTextProcessorTests
    {
        private InvalidTextProcessor _invalidTextProcessor;

        [SetUp]
        public void Setup()
        {
            _invalidTextProcessor = new InvalidTextProcessor();
        }

        [Test]
        [TestCase("I like eating apples", "Invalid operation. Cannot process 'I like eating apples'.")]
        public void Process_InvalidOperation_ReturnsCannotProcessTextMessage(string text, string expectedResult)
        {
            var result = _invalidTextProcessor.Process(text);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
