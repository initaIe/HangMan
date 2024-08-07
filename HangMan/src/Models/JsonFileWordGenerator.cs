using HangMan.src.BaseModels;
using HangMan.src.Interfaces;
using System.Text.Json;

namespace HangMan.src.Models
{
    public class JsonFileWordGenerator : FileWordGeneratorBase
    {
        protected readonly IDeserializer _deserializer;
        protected string[] _words;

        public JsonFileWordGenerator(IDeserializer deserializer, string fileName = "dictionary.json")
            : base(fileName)
        {
            _deserializer = deserializer;
            string json = File.ReadAllText(_fileName);
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
