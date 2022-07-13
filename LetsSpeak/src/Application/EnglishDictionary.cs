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
    public class EnglishDictionary : WordSearcher, IDictionary
    {
        //private static Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public string Word { get; set; }
        public string WordMeaning { get; set; }
    }
}
