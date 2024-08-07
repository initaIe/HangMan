using HangMan.src.Interfaces;

namespace HangMan.src.BaseModels
{
    public abstract class PlayerBase(IUsedLetterTracker usedLetterTracker,
        IMistakeTracker mistakeTracker): IPlayer
    {
        protected const int _maxMistakes = 5;
        protected readonly IUsedLetterTracker _usedLetterTracker = usedLetterTracker;
        protected readonly IMistakeTracker _mistakeTracker = mistakeTracker;

        public abstract bool IsPlayerLose { get; }
    }
}
