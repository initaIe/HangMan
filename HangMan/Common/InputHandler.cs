namespace HangMan.Common
{
    public class InputHandler
    {
        private Validator _validator = new();
        public char GetInput()
        {
            while (true)
            {
                Console.Write("Введите русскую букву: ");
                string userInput = Console.ReadLine();

                if (_validator.IsSingleRussianLetter(userInput, out char inputChar))
                {
                    return inputChar;
                }
            }
        }
    }
}
