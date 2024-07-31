using System.Text.Json;

namespace HangMan.Common.WordGeneration.FromFile
{
    public class JsonFileWordGenerator : FileWordGenerator
    {
        private string _jsonString;
        private string[] _word;
        public JsonFileWordGenerator(string fileName = "dictionary.json") : base(fileName)
        {
            _jsonString = File.ReadAllText(FileName);
            _word = JsonSerializer.Deserialize<string[]>(_jsonString);
        }
        public override string Generate()
        {
             return _word[GetRandomIndex()];
        }

        protected override int GetCountOfLines()
        {
            return _word.Length;   
        }

        protected override int GetRandomIndex()
        {
            return Random.Next(0, GetCountOfLines() - 1);
        }
    }
}
