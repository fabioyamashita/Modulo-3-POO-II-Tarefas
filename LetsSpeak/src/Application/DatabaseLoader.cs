using System.Xml.Serialization;

namespace LetsSpeak
{
    public static class DatabaseLoader
    {

        public static void Load(List<EnglishDictionary> dictionary, string englishDictionaryDb)
        {
            XmlSerializer dictionarySerializer = new XmlSerializer(typeof(List<EnglishDictionary>));
            using (TextReader reader = new StreamReader(englishDictionaryDb))
            {
                var dict = dictionarySerializer.Deserialize(reader) as List<EnglishDictionary>;
                dictionary = dict ?? new List<EnglishDictionary>();
            }
        }
    }
}