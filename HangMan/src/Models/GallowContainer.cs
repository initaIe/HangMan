namespace HangMan.src.Models
{
    public class GallowContainer
    {
        public List<List<string>> gallows { get; set; }

        public List<string> GetGallow(int id) => gallows.ElementAt(id);
    }
}
