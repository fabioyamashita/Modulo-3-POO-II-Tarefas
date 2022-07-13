namespace LetsSpeak
{
    public static class DatabaseInitializer
    {
        public static void Initialize(List<EnglishDictionary> englishDictionary, string dictionaryDb)
        {
            if (!File.Exists(dictionaryDb))
                DatabaseSaver.Save(englishDictionary, dictionaryDb);

            DatabaseLoader.Load(dictionaryDb);
        }
    }
}