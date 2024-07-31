using HangMan.Common.Interfaces;

namespace HangMan.Common.Classes
{
    public class Player : IPlayer
    {
        private const byte _maxMistakes = 5;
        private int _mistakes;
        private List<char> _usedLetters;
        public bool IsPlayerLose() => _mistakes > _maxMistakes;
        public bool IsUsedLetter(char letter) => _usedLetters.Contains(letter);
        public void AddMistake() => _mistakes++;
        public void AddUsedLetter(char letter) => _usedLetters.Add(letter);
        public string GetUsedLetters() => new string(_usedLetters.ToArray());
    }
}
