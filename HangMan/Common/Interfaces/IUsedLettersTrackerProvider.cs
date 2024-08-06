namespace HangMan.Common.Interfaces
{
    public interface IUsedLettersTrackerProvider
    {
        void Add(List<char> letters, char targetLetter);
        List<char> GetAll(List<char> letters);
        bool ContainsChar(List<char> letters, char targetLetter);
    }
}
