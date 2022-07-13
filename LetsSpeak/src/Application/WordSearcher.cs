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

            int wordsFound = 0;
            string wordSearch;

            do
            {
                wordSearch = Prompt.Input<string>("O que você está procurando?");

                if (WordSearchValidator.IsValidWord(wordSearch))
                    break;

                Console.Clear();
                Console.WriteLine("Digite uma palavra válida!");
            } while (true);

            foreach (var dict in Database.EnglishDictionary)
            {
                if (dict.Word.Contains(wordSearch.Trim().ToLower()))
                {
                    wordFound.Add(dict.Word);
                    wordFoundMeaning.Add(dict.WordMeaning);
                    wordsFound++;
                }
            }

            if (wordsFound == 0)
            {
                Console.WriteLine("Nenhum termo encontrado!");
                return;
            }

            Table table = new Table("Palavra", "Significado");
            for (int i = 0; i < wordFound.Count; i++)
            {
                table.AddRow(wordFound[i], wordFoundMeaning[i]);
            }

            Console.WriteLine($"\nResultado da busca pela palavra '{wordSearch.ToLower()}'");
            Console.WriteLine(table.ToString());
        }
    }
}