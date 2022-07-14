using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LetsSpeak
{
    public static class Database
    {
        private static readonly string _rootDirectory = AppDomain.CurrentDomain.BaseDirectory;
        public static readonly string _englishDictionaryDb = Path.Combine(_rootDirectory, "eng-dictionary.xml");

        public static List<EnglishDictionary> EnglishDictionary = new List<EnglishDictionary>();

        static Database()
        {
            DatabaseInitializer.Initialize(EnglishDictionary, _englishDictionaryDb);
        }
    }
}
