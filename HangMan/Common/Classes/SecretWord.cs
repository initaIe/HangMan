using HangMan.Common.Interfaces;

namespace HangMan.Common.Classes
{
    public class SecretWord : IWord
    {
        public string Word { get; private set; }
        public SecretWord(string word)
        {
            Word = word;
        }
    }
}
