using HangMan.src.Classes;
using HangMan.src.DeserializationModels;
using HangMan.src.Models;
using HangMan.src.Providers.Implementations;
using HangMan.src.Utilities;
using Microsoft.Extensions.Configuration;
using System.Reflection;

//var textFileReader = new TextDocumentReader();
//var gallowJsonDeserializer = new JsonDeserializer<GallowModel>();
//var gallowProvider = new GallowProvider(textFileReader, gallowJsonDeserializer);
//var res = gallowProvider.GetGallows("Resources/gallows.json");

string jsonString;
var assembly = Assembly.GetExecutingAssembly();
using (Stream stream = assembly.GetManifestResourceStream("HangMan.Resources.gallows.json"))
using (StreamReader reader = new StreamReader(stream))
{
    jsonString = reader.ReadToEnd();
}





Console.ReadLine();