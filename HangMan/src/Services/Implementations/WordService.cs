using HangMan.src.Interfaces;
using HangMan.src.Services.Interfaces;
using System.Text;

namespace HangMan.src.Services.Implementations
{
    public class WordService(IWord word) : IWordService
    {
        private readonly IWord _word = word;

        public string GetMaskedWord(List<char> charsToUnmask)
        {
            StringBuilder maskedWord = new StringBuilder();

            foreach (char c in _word.Word)
            {
                if (charsToUnmask.Contains(c)) maskedWord.Append(c);
                else maskedWord.Append('_');
            }

            return maskedWord.ToString();
        }
    }
}
