using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LetsSpeak
{
    public class Database
    {
        private static readonly string _rootDirectory = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string _englishDictionaryDb = Path.Combine(_rootDirectory, "eng-dictionary.xml");
        
        public static List<EnglishDictionary> EnglishDictionary = new List<EnglishDictionary>();

        static Database()
        {
            InitializeDatabase();
        }

        public static void InitializeDatabase()
        {
            if (!File.Exists(_englishDictionaryDb))
                Save();

            Load();
        }
        
        public static void Save()
        {
            Console.WriteLine("Salvando...");

            XmlSerializer dictionarySerializer = new XmlSerializer(typeof(List<EnglishDictionary>));
            using (TextWriter writer = new StreamWriter(_englishDictionaryDb))
            {
                dictionarySerializer.Serialize(writer, EnglishDictionary);
            }

            Console.WriteLine("Salvo.");
        }

        public static void Load()
        {
            XmlSerializer dictionarySerializer = new XmlSerializer(typeof(List<EnglishDictionary>));
            using (TextReader reader = new StreamReader(_englishDictionaryDb))
            {
                var dict = dictionarySerializer.Deserialize(reader) as List<EnglishDictionary>;
                EnglishDictionary = dict ?? new List<EnglishDictionary>();
            }
        }
    }
}
