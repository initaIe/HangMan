namespace HangMan.Common
{
    public class GuessWord
    {       
        public string HiddenWord { get; private set; }
        public string VisibleWord { get; private set; }
        public bool IsWordSolved => VisibleWord == HiddenWord;
        public GuessWord(string hiddenWord)
        {
            HiddenWord = hiddenWord;
            VisibleWord = new string('_', hiddenWord.Length);
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
