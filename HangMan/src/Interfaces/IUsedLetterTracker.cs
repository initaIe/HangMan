namespace HangMan.src.Interfaces
{
    public interface IUsedLetterTracker
    {
        IReadOnlyList<char> UsedLetters { get; }
        void AddLetter(char letter);
        bool HasLetter(char letter);
    }
}
