using HangMan.src.Interfaces;
using Steeltoe.Common.Http;

namespace HangMan.src.BaseModels
{
    public abstract class ApiWordGeneratorBase : IWordGenerator
    {
        protected string _apiUrl;
        //protected HttpClientHelper _httpClientHelper;
        public ApiWordGeneratorBase(string apiUrl)
        {
            _apiUrl = apiUrl;
            //_httpClientHelper = new();
        }
        public abstract string Generate();
    }
}
