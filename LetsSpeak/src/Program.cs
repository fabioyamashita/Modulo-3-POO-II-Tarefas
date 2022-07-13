using Sharprompt;

namespace LetsSpeak
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDictionary dict = new EnglishDictionary();
            INewWordRegister register = new NewWordRegister(dict);


            PromptConfig.DefaultConfig();
            Console.Title = "Let's Speak";


            IMenuItem mainMenu = new MenuItem("Main Menu");
            mainMenu.Add(new MenuItem("Register new word", register.AddWordToDatabase));
            mainMenu.Add(new MenuItem("Search word meaning", WordSearcher.Search));
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