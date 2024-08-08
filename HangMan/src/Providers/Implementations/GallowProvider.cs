﻿using HangMan.src.DeserializationModels;
using HangMan.src.Interfaces;
using HangMan.src.Providers.Interfaces;

namespace HangMan.src.Providers.Implementations
{
    public class GallowProvider
        (ITextDocumentReader textFormatFileReader,
        IDeserializer<GallowModel> deserializer) : IGallowProvider
    {
        private readonly ITextDocumentReader _textFormatFileReader = textFormatFileReader;
        private readonly IDeserializer<GallowModel> _deserializer = deserializer;
        public GallowModel GetGallows(string filePath)
        {
            string data = _textFormatFileReader.ReadFile(filePath);
            return _deserializer.Deserialize(data);
        }
    }
}