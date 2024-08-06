namespace HangMan.Common.Interfaces
{
    public interface IWordProvider
    {
        string MaskWord(string word, List<char> charsToUnmask);
        bool ContainsChar(string word, char targetLetter);
    }
}
