namespace HangMan
{
    public static class GuessWord
    {
        private const string _pathToTextFile = "dictionary.txt";
        private static string? _hiddenWord = String.Empty;
        public static string? VisibleWord { get; private set; } = String.Empty;

        // Initialization here for better randomness
        private static Random rnd = new();

        public static bool IsWordSolved
        {
            get
            {
                return VisibleWord == _hiddenWord;
            }
        }

        static GuessWord()
        {

        }

        public static void Reload()
        {
            GenerateHiddenWord();
            GenerateVisibeWord();
        }

        public static bool HasLetter(char letter)
        {
            return _hiddenWord.Contains(letter);
        }

        public static void OpenLettersInHiddenWord(char letter)
        {
            char[] visibleWordCharArr = VisibleWord.ToCharArray();

            for (int i = 0; i < _hiddenWord.Length; i++)
            {
                if (_hiddenWord[i] == letter)
                {
                    visibleWordCharArr[i] = letter;
                }
            }
            VisibleWord = new string(visibleWordCharArr);
        }

        private static void GenerateHiddenWord()
        {
            int countLinesInFile = File.ReadLines(_pathToTextFile).Count();

            int minIndex = 0;
            int maxIndex = countLinesInFile - 1;

            int hiddenWordIndex = rnd.Next(minIndex, maxIndex);

            _hiddenWord = File.ReadLines(_pathToTextFile)
            .ElementAtOrDefault(hiddenWordIndex);
        }

        private static void GenerateVisibeWord()
        {
            VisibleWord = new string('_', _hiddenWord.Length);
        }

        public static string GetHiddenWord()
        {
            if (Player.IsPlayerLose || IsWordSolved)
                return _hiddenWord;
            else
                return "Ошибка (Для отображения загаданного слова Вам необходимо проиграть/выиграть)";
        }

    }
}
