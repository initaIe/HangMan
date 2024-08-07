using HangMan.src.BaseModels;
using HangMan.src.Interfaces;

namespace HangMan.src.Models
{
    public class Player(IUsedLetterTracker usedLetterTracker, IMistakeTracker mistakeTracker)
        : PlayerBase(usedLetterTracker, mistakeTracker)
    {
        public override bool IsPlayerLose => _mistakeTracker.Mistakes > _maxMistakes;
    }
}
