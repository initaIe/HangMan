using HangMan.src.DeserializationModels;

namespace HangMan.src.Providers.Interfaces
{
    public interface IGallowProvider
    {
        GallowModel GetGallows(string filePath);
    }
}
