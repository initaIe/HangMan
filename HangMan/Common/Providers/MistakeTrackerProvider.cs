using HangMan.Common.Classes;
using HangMan.Common.Interfaces;

namespace HangMan.Common.Providers
{
    public class MistakeTrackerProvider : IMistakeTrackerProvider
    {
        public void Add(IMistakeTracker mistakeTracker) => mistakeTracker.Mistakes = 5;
    }
}
