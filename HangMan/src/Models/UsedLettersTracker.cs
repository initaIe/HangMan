using HangMan.src.Interfaces;

namespace HangMan.src.Models
{
    public class UsedLettersTracker : IUsedLetterTracker
    {
        private List<char> _usedLetters = new();
        public IReadOnlyList<char> UsedLetters => _usedLetters.AsReadOnly();
        public void AddLetter(char letter) => _usedLetters.Add(letter);
        public bool HasLetter(char letter) => _usedLetters.Contains(letter);
    }
}
