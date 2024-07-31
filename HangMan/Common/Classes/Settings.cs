using HangMan.Common.Enums;
using HangMan.Common.Interfaces;

namespace HangMan.Common.Classes
{
    public class Settings : ISettings
    {
        private Language _language;
        private Difficult _difficult;
        private Subject _subject;
        private Mode _mode;

        public Settings(Language language = Language.ru,
            Difficult difficult = Difficult.Easy,
            Subject subject = Subject.None)
        {
            _language = language;
            _difficult = difficult;
            _subject = subject;
        }

        public void Save(Language language, Difficult difficult, Subject subject)
        {
            throw new NotImplementedException();
        }
    }
}
