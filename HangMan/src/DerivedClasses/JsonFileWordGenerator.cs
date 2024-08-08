using HangMan.src.BaseModels;
using HangMan.src.Interfaces;

namespace HangMan.src.DerivedClasses
{
    public class JsonFileWordGenerator : FileWordGeneratorBase
    {
        protected private readonly IDeserializer<string[]> _deserializer;
        protected private string[] _words;

        public JsonFileWordGenerator(IDeserializer<string[]> deserializer, ITextDocumentReader textFormatFileReader,
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

        protected private override int GetCountOfLines()
        {
            return _words.Length;
        }
    }
}
