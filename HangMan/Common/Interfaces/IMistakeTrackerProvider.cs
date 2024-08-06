using HangMan.Common.Classes;

namespace HangMan.Common.Interfaces
{
    public interface IMistakeTrackerProvider
    {
        void Add(IMistakeTracker mistakeTracker);
    }
}