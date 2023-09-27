namespace TextProcessor.Helpers
{
    public static class ConsoleMessages
    {
        private static readonly Dictionary<string, string> _messages = new()
        {
            { "1", "for a duplicate character check" }, 
            { "2", "to count the number of vowels" }, 
            { "3", "to check if there are more vowels or non vowels"}
        };

        public const string ENTER_TEXT_MESSAGE = "Enter text to be analysed";

        public static string ENTER_OPERATIONS_MESSAGE = $"Enter which operations to do on the supplied text" +
            $", {string.Join(",", _messages.Select(i => $"'{i.Key}' {i.Value}").ToArray())}" +
            $", or any combination of {StringHelpers.ReplaceLastOccurrence(string.Join(",", _messages.Select(i => i.Key).ToArray()), ","," and ")}" +
            $" to perform multiple checks";
    }
}
