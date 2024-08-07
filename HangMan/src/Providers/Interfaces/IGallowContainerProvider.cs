namespace HangMan.src.Providers.Interfaces
{
    public interface IGallowContainerProvider<GallowContainer>
    {
        GallowContainer GetGallows(string filePath);
    }
}
