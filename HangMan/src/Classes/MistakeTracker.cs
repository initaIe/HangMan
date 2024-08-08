using HangMan.src.Interfaces;

namespace HangMan.src.Models
{
    public class MistakeTracker : IMistakeTracker
    {
        public int Mistakes { get; private set; } = 0;
        public void AddMistake() => Mistakes++;
    }
}
