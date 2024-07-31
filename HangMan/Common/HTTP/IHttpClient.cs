namespace HangMan.Common.HTTP
{
    public interface IHttpClient
    {
        public Task<string> GetAsync(string apiUrl);
    }
}
