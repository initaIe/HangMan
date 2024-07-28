using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HangMan
{
    public class Validator
    {
        public bool IsSingleRussianLetter(string userInput, out char validChar)
        {
            validChar = '\0';

            if (userInput.Length == 1 && userInput[0] >= 'а' && userInput[0] <= 'я')
            {
                validChar = userInput[0];
                return true;
            }

            return false;
        }
    }
}
