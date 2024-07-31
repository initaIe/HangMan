namespace HangMan.Common.Handlers
{
    /// <summary>
    /// Full ignore letter case
    /// </summary>
    public class GatheredWordHanlder
    {
        public string UnMask(string secretWord, string gatheredWord, char letter)
        {
            char[] gatheredWordCharArray = gatheredWord.ToCharArray();
            char lowerLetter = char.ToLower(letter);

            for (int i = 0; i < gatheredWordCharArray.Length; i++)
            {
                if (char.ToLower(secretWord[i]) == letter)
                {
                    gatheredWordCharArray[i] = letter;
                }
            }
            return new string(gatheredWordCharArray);
        }
    }
}
