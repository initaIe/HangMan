using HangMan.src.BaseModels;
using HangMan.src.Interfaces;

namespace HangMan.src.DerivedClasses
{
    public class TxtWordGenerator(ITextDocumentReader textFormatFileReader,
        string fileName = "dictionary.txt") : FileWordGeneratorBase(textFormatFileReader, fileName)
    {
        protected private override int GetCountOfLines()
        {
            return _textFormatFileReader.ReadFileLines(_fileName).Count();
        }

        public override string Generate()
        {
            int lineCount = GetCountOfLines();
            int randomIndex = GetRandomIndex(lineCount);

            return _textFormatFileReader.ReadFileLines(_fileName).ElementAt(randomIndex);
        }
    }
}
