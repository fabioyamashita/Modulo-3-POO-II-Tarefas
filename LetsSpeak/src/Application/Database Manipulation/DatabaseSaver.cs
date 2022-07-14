using System.Xml.Serialization;

namespace LetsSpeak
{
    public static class DatabaseSaver
    {
        public static void Save(List<EnglishDictionary> dictionary, string dictionaryDb)
        {
            Console.WriteLine("Saving...");

            XmlSerializer dictionarySerializer = new XmlSerializer(typeof(List<EnglishDictionary>));
            using (TextWriter writer = new StreamWriter(dictionaryDb))
            {
                dictionarySerializer.Serialize(writer, dictionary);
            }

            Console.WriteLine("Saved.");
        }
    }
}