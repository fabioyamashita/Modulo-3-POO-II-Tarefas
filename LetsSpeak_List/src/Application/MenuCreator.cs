using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsSpeak
{
    public class MenuCreator
    {
        public static void Init()
        {
            IMenuItem mainMenu = new MenuItem("MAIN MENU");
            mainMenu.Add(new MenuItem("Add New Term", EnglishDictionary.AddWordToDatabase));
            mainMenu.Add(new MenuItem("Search Tool", WordSearcher.Search));
            mainMenu.Add(new MenuItem("EXIT", () => Environment.Exit(0)));

            mainMenu.Execute();
        }
    }
}
