using HangMan.Common.Interfaces;
using System.Text;

namespace HangMan.Common.Providers
{
    public class WordProvider : IWordProvider
    {
        public bool ContainsChar(string secretWord, char letter)
        {
            return secretWord.Contains(letter);
        }

        public string MaskWord(string secretWord, List<char> charsToUnmask)
        {
            StringBuilder maskedWord = new StringBuilder();

            foreach (char c in secretWord)
            {
                if (charsToUnmask.Contains(c)) maskedWord.Append(c);
                else maskedWord.Append('_');
            }

            return maskedWord.ToString();
        }
    }
}
