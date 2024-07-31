using HangMan.Common.Enums;

namespace HangMan.Common.Interfaces
{
    public interface ISettings
    {
        void Save(Language newLanguage, Difficult newDifficult, Subject newSubject);

    }
}
