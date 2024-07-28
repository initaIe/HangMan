namespace HangMan
{
    public class Player
    {
        private const int _maxMistakes = 5;
        public int Mistakes { get; private set; } = 0;
        private List<char> _usedLetters = new();
        public bool IsPlayerLose
        {
            get => Mistakes > _maxMistakes;
        }

        public void AddMistake()
        {
            Mistakes++;
        }

        public bool IsUsedLetter(char letter)
        {
            return _usedLetters.Contains(letter);
        }

        public void AddUsedLetter(char letter)
        {
            _usedLetters.Add(letter);
        }

        public void ShowUsedLetters()
        {
            var initialCursorPosition = Console.GetCursorPosition();

            Console.SetCursorPosition(10, 0);
            Console.Write("Использованные буквы: ");

            foreach (char letter in _usedLetters)
            {
                Console.Write($"{letter} ");
            }
            Console.SetCursorPosition(initialCursorPosition.Left, initialCursorPosition.Top);
        }
    }
}
