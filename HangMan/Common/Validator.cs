namespace HangMan.Common
{
    public class Validator
    {
        public bool IsSingleRussianLetter(string userInput, out char validLowercaseChar)
        {
            validLowercaseChar = '\0';

            if (
                userInput.Length == 1 &&
                (userInput[0] >= 'А' && userInput[0] <= 'я' || userInput[0] == 'ё' || userInput[0] == 'Ё')
               )
            {
                validLowercaseChar = userInput.ToLower()[0];
                return true;
            }

            return false;
        }
    }
}
