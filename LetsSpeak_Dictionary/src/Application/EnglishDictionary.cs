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
        [Display(Name = "Word")]
        public string Word { get; set; }

        [Display(Name = "Meaning")]
        public string WordMeaning { get; set; }

        public static void AddWordToDatabase()
        {
            Console.Clear();
            var newWord = Prompt.Bind<EnglishDictionary>();

            foreach (var dict in Database.EnglishDictionary)
            {
                if (string.Equals(dict.Key, newWord.Word, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Word already exists!");
                    return;
                }
            }

            var confirmWord = Prompt.Confirm("Confirm?");

            if (!confirmWord)
                return;

            Database.EnglishDictionary.Add(newWord.Word, newWord.WordMeaning);
            DatabaseSaver.Save(Database.EnglishDictionary, Database._englishDictionaryDb);

            Console.Clear();
            Console.WriteLine($"\n'{newWord.Word}' successfully added!");
        }
    }
}
