using Sharprompt;

namespace LetsSpeak
{
    public class PromptConfig
    {
        public static void DefaultConfig()
        {
            Prompt.ColorSchema.Answer = ConsoleColor.White;
            Prompt.ColorSchema.Select = ConsoleColor.Green;
            Prompt.ColorSchema.Error = ConsoleColor.Red;

            Prompt.Symbols.Prompt = new Symbol("", "");
            Prompt.Symbols.Done = new Symbol("", "");
            Prompt.Symbols.Error = new Symbol("", "");
        }
    }
}