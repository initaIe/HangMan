namespace HangMan.src.Interfaces
{
    public interface ITextDocumentReader

    {
        string ReadFile(string filePath);
        IEnumerable<string> ReadFileLines(string filePath);
        string[] ReadAllFileLines(string filePath);
    }
}
