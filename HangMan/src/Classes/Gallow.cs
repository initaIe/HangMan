using HangMan.src.Providers.Implementations;
using HangMan.src.Providers.Interfaces;
using HangMan.src.Utilities;

namespace HangMan.src.Classes
{
    public class Gallow
    {
        private readonly IGallowProvider _gallowProvider;
        public Gallow(IGallowProvider _gallowProvider)
        {
            //Gallows = _gallowProvider.GetGallows(FilesPaths.GallowsJsonPath);
        }

        public List<List<string>> Gallows { get; private set; }
    }
}
