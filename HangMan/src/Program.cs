using HangMan.src.Models;
using HangMan.src.Providers.Implementations;

var textFormatFileReader = new TextFormatFileReader();
var deserializer = new JsonDeserializer<GallowContainer>();

var gallowContainerProvider =
    new GallowContainerProvider<GallowContainer>(textFormatFileReader, deserializer);

var res = gallowContainerProvider.GetGallows("gallows.json");

var temp = res.GetGallow(1);






Console.ReadLine();