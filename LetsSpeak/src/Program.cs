using Sharprompt;

namespace LetsSpeak
{
    public class Program
    {
        static void Main(string[] args)
        {
            PromptConfig.DefaultConfig();
            Console.Title = "Let's Speak";

            EnglishDictionary dict = new EnglishDictionary();

            var mainMenu = new MenuItem("Main Menu");
            mainMenu.Add(new MenuItem("Register new word", dict.AddWordToDatabase));
            mainMenu.Add(new MenuItem("Search word meaning", dict.SearchWord));
            mainMenu.Add(new MenuItem("EXIT", () => Environment.Exit(0)));

            mainMenu.Execute();
            
            //Dictionary<string, string> dictionary = new Dictionary<string, string>();
            //dictionary.Add("ball", "bola");
            //dictionary.Add("speak", "falar");
            //dictionary.Add("test pear", "sweet fruit");
            //dictionary.Add("peacock", "pavão");
            //dictionary.Add("spear", "lança");

        }
    }
}