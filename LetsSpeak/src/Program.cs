using Sharprompt;
using Microsoft.Extensions.DependencyInjection;

namespace LetsSpeak
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDictionary dict = new EnglishDictionary();
            INewWordRegister register = new NewWordRegister(dict);

            //var serviceColletion = new ServiceCollection()
            //    .AddScoped<IDictionary, EnglishDictionary>()
            //    .AddScoped<INewWordRegister, NewWordRegister>();

            PromptConfig.DefaultConfig();
            Console.Title = "Let's Speak";

            IMenuItem mainMenu = new MenuItem("Main Menu");
            mainMenu.Add(new MenuItem("Adicionar Termo", register.AddWordToDatabase));
            mainMenu.Add(new MenuItem("Procurar Significados", WordSearcher.Search));
            mainMenu.Add(new MenuItem("SAIR", () => Environment.Exit(0)));

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