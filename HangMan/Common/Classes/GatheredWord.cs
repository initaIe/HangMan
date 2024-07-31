using HangMan.Common.Handlers;
using HangMan.Common.Interfaces;
using System.Runtime.CompilerServices;

namespace HangMan.Common.Classes
{
    public class GatheredWord : IGatheredWord
    {
        public string Word { get; private set; }
        private GatheredWordHanlder _gatheredWordHanlder;
        public GatheredWord(string word)
        {
            _gatheredWordHanlder = new();
            Word = word;
        }

        public void OpenLetters(string secretWord, char letter)
        {
            _gatheredWordHanlder.UnMask(secretWord, Word, letter);
        }
    }
}
