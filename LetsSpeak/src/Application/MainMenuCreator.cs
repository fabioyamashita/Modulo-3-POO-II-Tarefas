namespace LetsSpeak
{
    public class MainMenuCreator : IMainMenuCreator
    {
        private readonly INewWordRegister _newWordRegister;

        public MainMenuCreator(INewWordRegister newWordRegister)
        {
            _newWordRegister = newWordRegister;
        }

        public IMenuItem Create()
        {
            IMenuItem mainMenu = new MenuItem("Main Menu");
            mainMenu.Add(new MenuItem("Adicionar Termo", _newWordRegister.AddWordToDatabase));
            mainMenu.Add(new MenuItem("Procurar Significados", WordSearcher.Search));
            mainMenu.Add(new MenuItem("EXIT", () => Environment.Exit(0)));

            return mainMenu;
        }
    }
}