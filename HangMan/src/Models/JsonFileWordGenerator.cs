using HangMan.src.BaseModels;
using HangMan.src.Interfaces;

namespace HangMan.src.Models
{
    public class JsonFileWordGenerator : FileWordGeneratorBase
    {
        protected readonly IDeserializer<string[]> _deserializer;
        protected string[] _words;

        public JsonFileWordGenerator(IDeserializer<string[]> deserializer, ITextFormatFileReader textFormatFileReader,
            string fileName = "dictionary.json") : base(textFormatFileReader, fileName)
        {
            _deserializer = deserializer;
            string json = _textFormatFileReader.ReadFile(_fileName);
            _words = _deserializer.Deserialize(json);
        }

        public override string Generate()
        {
            int lineCount = GetCountOfLines();
            int randomIndex = GetRandomIndex(lineCount);

            return _words[randomIndex];
        }

        protected override int GetCountOfLines()
        {
            return _words.Length;
        }
    }
}
