namespace HangMan.Common.WordGeneration.FromFile
{
    public abstract class FileWordGenerator : IWordGenerator
    {
        protected string FileName;
        protected Random Random;
        public FileWordGenerator(string fileName)
        {
            FileName = fileName;
            Random = new Random();
        }

        public abstract string Generate();        
        protected abstract int GetCountOfLines();
        protected abstract int GetRandomIndex();
    }
}
