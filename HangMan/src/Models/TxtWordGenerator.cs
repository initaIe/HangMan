using HangMan.src.BaseModels;
using HangMan.src.Interfaces;

namespace HangMan.src.Models
{
    public class TxtWordGenerator(ITextFormatFileReader textFormatFileReader,
        string fileName = "dictionary.txt") : FileWordGeneratorBase(textFormatFileReader, fileName)
    {
        protected override int GetCountOfLines()
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
