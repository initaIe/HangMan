using HangMan.Common.Interfaces;

namespace HangMan.Common.Classes
{
    public class SecretWord : ISecretWord
    {
        public string Word { get; private set; }
        public SecretWord(string word)
        {
            Word = word;
        }

        public bool HasLetter(char letter) => Word.Contains(letter);        
    }
}
