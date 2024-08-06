using HangMan.Common.Interfaces;

namespace HangMan.Common.Services
{
    public class WordService
    {
        private readonly IWordProvider _wordProvider;

        public WordService(IWordProvider wordProvider)
        {
            _wordProvider = wordProvider;
        }

        public string GetMaskedWord(IWord word,List<char> charsToUnmask) =>
            _wordProvider.MaskWord(word.Word, charsToUnmask);
        

        public bool HasLetter(IWord word, char targetLetter) =>
            _wordProvider.ContainsChar(word.Word, targetLetter);
        
    }
} 
