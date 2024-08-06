using HangMan.Common.Interfaces;

namespace HangMan.Common.Classes
{
    public class MistakeTracker : IMistakeTracker
    {
        public int Mistakes { get; private set; } = 0;

        public void Increment() => Mistakes++;
    }
}
