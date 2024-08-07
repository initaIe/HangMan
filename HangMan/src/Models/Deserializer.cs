using HangMan.src.Interfaces;
using System.Text.Json;

namespace HangMan.src.Models
{
    public class Deserializer : IDeserializer
    {
        public string[] Deserialize(string jsonString)
        {
            if (string.IsNullOrEmpty(jsonString))            
                throw new ArgumentNullException(nameof(jsonString), "Input JSON string cannot be null or empty.");
            
            try
            {
                return JsonSerializer.Deserialize<string[]>(jsonString);
            }
            catch (JsonException ex)
            {
                throw new InvalidOperationException("Invalid JSON format.", ex);
            }
        }
    }
}
