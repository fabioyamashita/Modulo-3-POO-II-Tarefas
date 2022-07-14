namespace LetsSpeak
{
    public class WordValidator
    {
        public static bool IsValidWordInput(string word)
        {
            if (String.IsNullOrEmpty(word) || word.Any(c => !char.IsLetter(c)))
                return false;

            return true;
        }
    }
}