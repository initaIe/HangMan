namespace HangMan.Common.WordGeneration.FromFile
{
    public class TxtFileWordGenerator : FileWordGenerator
    {
        public TxtFileWordGenerator(string fileName = "dictionary.txt") : base(fileName)
        {
        }

        protected override int GetCountOfLines()
        {
            return File.ReadLines(FileName).Count();
        }
        protected override int GetRandomIndex()
        {
            return Random.Next(0, GetCountOfLines() - 1);
        }
        public override string Generate()
        {
            return File.ReadLines(FileName)
            .ElementAtOrDefault(GetRandomIndex());
        }
    }
}
