using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharprompt;
using BetterConsoleTables;
using System.ComponentModel.DataAnnotations;

namespace LetsSpeak
{
    public class EnglishDictionary
    {
        //private static Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public string Word { get; set; }
        public string WordMeaning { get; set; }

        public void AddWordToDatabase()
        {
            Console.Clear();
            Word = Prompt.Input<string>("Adicione a palavra em inglês");
            WordMeaning = Prompt.Input<string>("Significado");

            Database.EnglishDictionary.Add(this);
            Database.Save();

            Console.Clear();
            Console.WriteLine("\nNova palavra adicionada com sucesso!");
            Console.WriteLine($"Palavra: {Word.ToLower()}");
            Console.WriteLine($"Significado: {WordMeaning.ToLower()}");
        }

        public void SearchWord()
        {
            List<string> wordFound = new List<string>();
            List<string> wordFoundMeaning = new List<string>();

            int wordsFound = 0;
            string wordSearch;

            do
            {
                wordSearch = Prompt.Input<string>("O que você está procurando?");
                
                if (IsValidWord(wordSearch))
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

        public static bool IsValidWord(string word)
        {
            if (word.Any(c => !char.IsLetter(c)))
                return false;

            return true;
        }
    }
}
