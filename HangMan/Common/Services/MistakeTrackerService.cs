using HangMan.Common.Interfaces;

namespace HangMan.Common.Services
{
    public class MistakeTrackerService
    {
        private readonly IMistakeTrackerProvider _mistakeTrackerProvider;

        public MistakeTrackerService(IMistakeTrackerProvider mistakeTrackerProvider)
        {
            _mistakeTrackerProvider = mistakeTrackerProvider;
        }
    }
}
