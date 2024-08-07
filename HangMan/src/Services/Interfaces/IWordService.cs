namespace HangMan.src.Services.Interfaces
{
    public interface IWordService
    {
        string GetMaskedWord(List<char> charsToUnmask);
    }
}