using HangMan.src.Interfaces;

namespace HangMan.src.Models
{
    public class SecretWord(string word) : IWord
    {
        public string Word { get; private set; } = word;
        public bool HasLetter(char letter) => Word.Contains(letter);
    }
}
