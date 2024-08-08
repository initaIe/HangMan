using HangMan.src.Classes;
using HangMan.src.DeserializationModels;
using HangMan.src.Models;
using HangMan.src.Providers.Implementations;
using HangMan.src.Utilities;
using Microsoft.Extensions.Configuration;

//var textFileReader = new TextFormatFileReader();
//var gallowJsonDeserializer = new JsonDeserializer<GallowModel>();
//var gallowProvider = new GallowProvider(textFileReader, gallowJsonDeserializer);
//var res = gallowProvider.GetGallows("gallows.json");

var configuration = new ConfigurationBuilder()
    .AddInMemoryCollection(new Dictionary<string, string?>()
    {
        ["gallowsPath"] = "pathxdxd"
    })
    .Build();

Console.WriteLine(configuration["gallowsPath"]);




Console.ReadLine();