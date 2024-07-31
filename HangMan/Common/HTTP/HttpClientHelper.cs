namespace HangMan.Common.HTTP
{
    public class HttpClientHelper : IHttpClient
    {
        private readonly HttpClient _httpClient;

        public HttpClientHelper() => _httpClient = new HttpClient();

        public async Task<string> GetAsync(string url)
        {
            var response = await _httpClient.GetAsync(url);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
