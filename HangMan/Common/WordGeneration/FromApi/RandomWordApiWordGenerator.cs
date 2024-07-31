using HangMan.Common.HTTP;
using Steeltoe.Common.Http;
using System.Text.Json;

namespace HangMan.Common.WordGeneration.API
{
    public class RandomWordApiWordGenerator : ApiWordGenerator
    {
        private string[] _word;

        public RandomWordApiWordGenerator(string apiUrl = "https://random-word-api.vercel.app/api") : base(apiUrl)
        {
            InitializeAsync().GetAwaiter().GetResult();
        }

        public async Task InitializeAsync()
        {
            string jsonString = await HttpClientHelper.GetAsync(ApiUrl);
            _word = JsonSerializer.Deserialize<string[]>(jsonString);
        }

        public override string Generate()
        {
            return _word[0];
        }
    }
}
