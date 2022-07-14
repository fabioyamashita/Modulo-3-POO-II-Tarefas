namespace LetsSpeak
{
    public static class DatabaseInitializer
    {
        public static void Initialize(Dictionary<string, string> englishDictionary, string dictionaryDb)
        {
            if (!File.Exists(dictionaryDb))
                DatabaseSaver.Save(englishDictionary, dictionaryDb);

            DatabaseLoader.Load(dictionaryDb);
        }
    }
}