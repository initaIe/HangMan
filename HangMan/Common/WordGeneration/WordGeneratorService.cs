namespace HangMan.Common.WordGeneration
{
    public class WordGeneratorService
    {
        private readonly IWordGenerator _wordGenerator;
        public WordGeneratorService(IWordGenerator wordGenerator)
        {
            _wordGenerator = wordGenerator;
        }

        public string Generate()
        {
            return _wordGenerator.Generate();
        }
    }
}
