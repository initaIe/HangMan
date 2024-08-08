using HangMan.src.Interfaces;

namespace HangMan.src.BaseModels
{
    public abstract class FileWordGeneratorBase
        (ITextDocumentReader textFormatFileReader, string fileName) : IWordGenerator
    {
        protected private readonly ITextDocumentReader _textFormatFileReader = textFormatFileReader;
        protected private string _fileName = fileName;
        protected private Random _random = new();

        protected private abstract int GetCountOfLines();
        protected private virtual int GetRandomIndex(int countLines) =>
            _random.Next(0, countLines - 1);
        public abstract string Generate();
    }
}
