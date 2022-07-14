using System.Xml.Serialization;
using Newtonsoft.Json;

namespace LetsSpeak
{
    public static class DatabaseLoader
    {
        public static void Load(string dictionaryDb)
        {
            var content = File.ReadAllText(dictionaryDb);
            Database.EnglishDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);
        }
    }
}