namespace HangMan
{
    public class InputHandler
    {
        private Validator _validator = new();
        public void GetUserInput(out char letter)
        {
            while (true)
            {
                Console.Write("Введите русскую букву: ");
                string userInput = Console.ReadLine().ToLower();

                if (_validator.IsSingleRussianLetter(userInput, out char inputChar))
                {
                    letter = inputChar;
                    break;
                }
            }
        }
    }
}
