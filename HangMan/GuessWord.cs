namespace HangMan
{
    public class GuessWord
    {
        public string? HiddenWord { get; private set; } = WordGenerator.GetRandomWord();
        public string? VisibleWord { get; private set; }
        public bool IsWordSolved
        {
            get => VisibleWord == HiddenWord;
        }

        public GuessWord()
        {
            VisibleWord = new string('_', HiddenWord.Length);
        }

        public bool HasLetter(char letter)
        {
            return HiddenWord.Contains(letter);
        }

        public void OpenLetterInHiddenWord(char letter)
        {
            char[] visibleWordCharArr = VisibleWord.ToCharArray();

            for (int i = 0; i < HiddenWord.Length; i++)
            {
                if (HiddenWord[i] == letter)
                {
                    visibleWordCharArr[i] = letter;
                }
            }
            VisibleWord = new string(visibleWordCharArr);
        }

        public void PrintVisibleWord()
        {
            Console.WriteLine($"\nЗагаданное слово: {VisibleWord} ");
        }
    }
}
