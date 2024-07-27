namespace HangMan
{
    public class HandleInput
    {
        private string _userInput;
        private bool IsRussianLetter
        {
            get
            {
                return _userInput.Length == 1
                        && Convert.ToChar(_userInput) >= 'а'
                        && Convert.ToChar(_userInput) <= 'я';
            }
        }

        public void GetUserInput(out char letter)
        {
            Console.Write("Введите русскую букву: ");

            while (true)
            {
                GetInput();
                if (IsRussianLetter)
                {
                    letter = Convert.ToChar(_userInput);
                    break;
                }
                else                
                    Console.Write("Ввод неверен.\nВведите русскую букву: ");                
            }
        }
        private void GetInput()
        {
            _userInput = Console.ReadLine().ToLower();
        }
    }
}
