using HangMan.src.Interfaces;

namespace HangMan.src.Models
{
    public class TextFormatFileReader : ITextFormatFileReader
    {
        public string[] ReadAllFileLines(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("Path cannot be null or empty.", nameof(filePath));

            try
            {
                return File.ReadAllLines(filePath);
            }
            catch (IOException ex)
            {
                throw new Exception("Error reading the file.", ex);
            }
        }

        public string ReadFile(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("Path cannot be null or empty.", nameof(filePath));

            try
            {
                return File.ReadAllText(filePath);
            }
            catch (IOException ex)
            {
                throw new Exception("Error reading the file.", ex);
            }
        }

        public IEnumerable<string> ReadFileLines(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("Path cannot be null or empty.", nameof(filePath));

            try
            {
                return File.ReadLines(filePath);
            }
            catch (IOException ex)
            {
                throw new Exception("Error reading the file.", ex);
            }
        }
    }
}
