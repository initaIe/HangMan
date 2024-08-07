using HangMan.src.Interfaces;

namespace HangMan.src.BaseModels
{
    public abstract class FileWordGeneratorBase(ITextFormatFileReader textFormatFileReader,
        string fileName) : IWordGenerator
    {
        protected readonly ITextFormatFileReader _textFormatFileReader = textFormatFileReader;
        protected string _fileName = fileName;
        protected Random _random = new();

        protected abstract int GetCountOfLines();
        protected virtual int GetRandomIndex(int countLines) =>
            _random.Next(0, countLines - 1);
        public abstract string Generate();
    }
}
