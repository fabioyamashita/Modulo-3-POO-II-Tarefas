using Sharprompt;
using Microsoft.Extensions.DependencyInjection;

namespace LetsSpeak
{
    public class Program
    {
        static void Main(string[] args)
        {
            DefaultConfig.Init();
            MenuCreator.Init();
        }
    }
}