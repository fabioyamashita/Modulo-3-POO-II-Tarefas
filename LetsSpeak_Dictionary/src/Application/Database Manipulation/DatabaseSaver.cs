using System.Xml.Serialization;
using Newtonsoft.Json;

namespace LetsSpeak
{
    public static class DatabaseSaver
    {
        public static void Save(Dictionary<string, string> dictionary, string dictionaryDb)
        {
            Console.WriteLine("Salvando...");

            var conteudo = JsonConvert.SerializeObject(dictionary);

            File.WriteAllText(dictionaryDb, conteudo);

            Console.WriteLine("Salvo.");
        }
    }
}