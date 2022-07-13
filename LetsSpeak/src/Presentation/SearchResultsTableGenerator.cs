using BetterConsoleTables;

namespace LetsSpeak
{
    public class SearchResultsTableGenerator
    {
        public static void Show(List<string> wordFound, List<string> wordFoundMeaning)
        {
            Table table = new Table("Palavra", "Significado");
            for (int i = 0; i < wordFound.Count; i++)
            {
                table.AddRow(wordFound[i], wordFoundMeaning[i]);
            }

            Console.WriteLine(table.ToString());
        }
    }
}