namespace HangMan
{
    public static class WordGenerator
    {
        private const string _pathToTextFile = "dictionary.txt";
        private static Random rnd = new();

        public static string GetRandomWord()
        {
            return File.ReadLines(_pathToTextFile).ElementAtOrDefault(GetRandomIndex());
        }

        private static int GetCountOfLines()
        {
            return File.ReadLines(_pathToTextFile).Count();
        }

        private static int GetRandomIndex()
        {
            return rnd.Next(0, GetCountOfLines() - 1);
        }
    }
}
