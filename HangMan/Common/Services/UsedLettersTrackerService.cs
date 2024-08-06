using HangMan.Common.Interfaces;

namespace HangMan.Common.Services
{
    public class UsedLettersTrackerService
    {
        private readonly IUsedLettersTrackerProvider _usedLettersTrackerProvider;

        public UsedLettersTrackerService(IUsedLettersTrackerProvider usedLettersTrackerProvider)
        {
            _usedLettersTrackerProvider = usedLettersTrackerProvider;
        }

        public void AddUsedLetter(IUsedLettersTracker usedLettersTracker, char targetLetter) =>
            _usedLettersTrackerProvider.Add(usedLettersTracker.Letters, targetLetter);

        public List<char> GetUsedLetters(IUsedLettersTracker usedLettersTracker) =>
             _usedLettersTrackerProvider.GetAll(usedLettersTracker.Letters);

        public bool HasUsedLetter(IUsedLettersTracker usedLettersTracker, char targetLetter) =>
            _usedLettersTrackerProvider.ContainsChar(usedLettersTracker.Letters, targetLetter);
    }
}
