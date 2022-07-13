using Sharprompt;

namespace LetsSpeak
{
    public class NewWordRegister : INewWordRegister
    {
        private readonly IDictionary _englishDictionary;

        public NewWordRegister(IDictionary englishDictionary)
        {
            _englishDictionary = englishDictionary;
        }

        public void AddWordToDatabase()
        {
            Console.Clear();
            _englishDictionary.Word = Prompt.Input<string>("Adicione a palavra em inglês");
            _englishDictionary.WordMeaning = Prompt.Input<string>("Significado");

            Console.WriteLine($"\nPalavra: {_englishDictionary.Word.ToLower()}");
            Console.WriteLine($"Significado: {_englishDictionary.WordMeaning.ToLower()}");

            var confirmWord = Prompt.Confirm("Confirma?");

            if (!confirmWord)
                return;

            Database.EnglishDictionary.Add((EnglishDictionary)_englishDictionary);
            Database.Save();

            Console.Clear();
            Console.WriteLine($"\nA palavra '{_englishDictionary.Word}' foi adicionada com sucesso!");
        }
    }
}