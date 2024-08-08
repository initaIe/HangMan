using HangMan.src.Interfaces;

namespace HangMan.src.BaseModels
{
    public abstract class PlayerBase
        (IUsedLetterTracker usedLetterTracker, IMistakeTracker mistakeTracker) : IPlayer
    {
        protected private const int _maxMistakes = 5;
        protected private readonly IUsedLetterTracker _usedLetterTracker = usedLetterTracker;
        protected private readonly IMistakeTracker _mistakeTracker = mistakeTracker;

        public abstract bool IsPlayerLose { get; }
    }
}
