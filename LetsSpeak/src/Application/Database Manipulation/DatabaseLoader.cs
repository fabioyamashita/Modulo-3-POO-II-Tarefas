using System.Xml.Serialization;

namespace LetsSpeak
{
    public static class DatabaseLoader
    {
        public static void Load(string dictionaryDb)
        {
            XmlSerializer dictionarySerializer = new XmlSerializer(typeof(List<EnglishDictionary>));
            using (TextReader reader = new StreamReader(dictionaryDb))
            {
                var dict = dictionarySerializer.Deserialize(reader) as List<EnglishDictionary>;
                Database.EnglishDictionary = dict ?? new List<EnglishDictionary>();
            }
        }
    }
}