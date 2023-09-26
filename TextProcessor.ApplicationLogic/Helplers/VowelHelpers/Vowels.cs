namespace TextProcessor.ApplicationLogic.Helplers.VowelHelpers
{
    public static class VowelsHelper
    {
        public static Dictionary<char, char> GetVowels()
        {
            return new Dictionary<char, char>()
            {
                {'a', 'a'},
                {'e', 'e'},
                {'i', 'i'},
                {'o', 'o'},
                {'u', 'u'},
            };
        }
    }
}
