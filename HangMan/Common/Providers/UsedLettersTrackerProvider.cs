using HangMan.Common.Interfaces;

namespace HangMan.Common.Providers
{
    public class UsedLettersTrackerProvider : IUsedLettersTrackerProvider
    {
        public void Add(List<char> usedLettersTracker, char targetLetter) =>
            usedLettersTracker.Add(targetLetter);
        public List<char> GetAll(List<char> usedLettersTracker) =>
            usedLettersTracker;
        public bool ContainsChar(List<char> usedLettersTracker, char targetLetter) =>
            usedLettersTracker.Contains(targetLetter);
    }
}
