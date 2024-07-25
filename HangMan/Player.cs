namespace HangMan
{
    public static class Player
    {
        // 6 mistakes, the player loses
        private const int _maxNumberOfMistakes = 5;
        public static int Mistakes { get; private set; } = 0;
        public static List<char> UsedLetters { get; private set; } = new();
        public static bool IsPlayerLose
        {
            get
            {
                return Mistakes > _maxNumberOfMistakes;
            }
        }
        public static void AddMistake()
        {
            Mistakes++;
        }

        public static void Reset()
        {
            if (GuessWord.IsWordSolved || IsPlayerLose)
            {
                Mistakes = 0;
                UsedLetters.Clear();
            }            
        }
    }
}
