﻿namespace LetsSpeak
{
    public class WordValidator
    {
        public static bool IsValidWord(string word)
        {
            if (word.Any(c => !char.IsLetter(c)) || String.IsNullOrEmpty(word))
                return false;

            return true;
        }
    }
}