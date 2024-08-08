using HangMan.src.Interfaces;
using System.Text.Json;

namespace HangMan.src.Models
{
    public class JsonDeserializer<T> : IDeserializer<T>
    {
        public T Deserialize(string data)
        {
            if (string.IsNullOrEmpty(data))
                throw new ArgumentNullException(nameof(data), "Input JSON string cannot be null or empty.");

            try
            {
                return JsonSerializer.Deserialize<T>(data);
            }
            catch (JsonException ex)
            {
                throw new InvalidOperationException("Invalid JSON format.", ex);
            }
        }
    }
}
