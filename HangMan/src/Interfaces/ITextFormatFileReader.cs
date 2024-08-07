namespace HangMan.src.Interfaces
{
    public interface ITextFormatFileReader
    {
        string ReadFile(string filePath);
        IEnumerable<string> ReadFileLines(string filePath);
        string[] ReadAllFileLines(string filePath);
    }
}
