using BetterConsoleTables;
using Sharprompt;

namespace LetsSpeak
{
    public class WordSearcher
    {
        public static void Search()
        {
            List<string> wordFound = new List<string>();
            List<string> wordFoundMeaning = new List<string>();

            string wordSearch = WordSearchInput.Validate();

            foreach (var dict in Database.EnglishDictionary)
            {
                if (dict.Word.Contains(wordSearch.Trim().ToLower()))
                {
                    wordFound.Add(dict.Word);
                    wordFoundMeaning.Add(dict.WordMeaning);
                }
            }

            if (wordFound.Count == 0)
            {
                Console.WriteLine("Nenhum termo encontrado!");
                return;
            }

            Console.WriteLine($"\nResultado da busca pela palavra '{wordSearch.ToLower()}'");

            SearchResultsTableGenerator.Show(wordFound, wordFoundMeaning);
        }
    }
}