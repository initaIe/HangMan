namespace HangMan.src.Interfaces
{
    public interface IWord
    {
        string Word { get; }
        bool HasLetter(char letter);
    }
}
