using HangMan.Common.Interfaces;

namespace HangMan.Common.Classes
{
    public class UsedLettersTracker : IUsedLettersTracker
    {
        public List<char> Letters { get; private set; } = new();
    }
}
