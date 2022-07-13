
namespace LetsSpeak
{
    public interface IMenuItem
    {
        Action Action { get; }
        List<MenuItem> Items { get; }
        MenuItem Parent { get; }
        string Title { get; }

        void Add(MenuItem menuItem);
        void Execute();
        string ToString();
    }
}