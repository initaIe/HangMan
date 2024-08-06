namespace HangMan.Common.Interfaces
{
    public interface IMistakeTracker
    {
        int Mistakes { get; }
        void Increment();
    }
}