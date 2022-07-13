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
                wordSearch = Prompt.Input<string>("O que você está procurando?");

                if (WordValidator.IsValidWord(wordSearch))
                    break;

                Console.Clear();
                Console.WriteLine("Digite uma palavra válida!");

            } while (true);

            return wordSearch;
        }
    }
}