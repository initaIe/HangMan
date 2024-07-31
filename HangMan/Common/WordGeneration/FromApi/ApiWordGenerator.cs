using HangMan.Common.HTTP;

namespace HangMan.Common.WordGeneration.API
{
    public abstract class ApiWordGenerator : IWordGenerator
    {
        protected string ApiUrl;
        protected HttpClientHelper HttpClientHelper;
        public ApiWordGenerator(string apiUrl)
        {
            ApiUrl = apiUrl;
            HttpClientHelper = new();
        }
        public abstract string Generate();
    }
}
