using Sharprompt;

namespace LetsSpeak
{
    public class WordSearchInput
    {
        public static string Validate()
        {
            string wordSearch;
            do
            {
                wordSearch = Prompt.Input<string>("What are you looking for?");

                if (WordValidator.IsValidWordInput(wordSearch))
                    break;

                Console.Clear();
                Console.WriteLine("Please, write a valid word!");

            } while (true);

            return wordSearch;
        }
    }
}