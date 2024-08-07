using HangMan.src.Interfaces;
using HangMan.src.Providers.Interfaces;

namespace HangMan.src.Providers.Implementations
{
    public class GallowContainerProvider<GallowContainer>(ITextFormatFileReader textFormatFileReader,
        IDeserializer<GallowContainer> deserializer) : IGallowContainerProvider<GallowContainer>
    {
        private readonly ITextFormatFileReader _textFormatFileReader = textFormatFileReader;
        private readonly IDeserializer<GallowContainer> _deserializer = deserializer;
        public GallowContainer GetGallows(string filePath)
        {
            string data = _textFormatFileReader.ReadFile(filePath);
            return _deserializer.Deserialize(data);
        }
    }
}