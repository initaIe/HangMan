namespace HangMan
{
    public static class Game
    {
        public static void StartGame()
        {
            while (true)
            {
                Player.Reset();
                GuessWord.Reload();

                while (!GuessWord.IsWordSolved && !Player.IsPlayerLose)
                {
                    Console.Clear();

                    Console.WriteLine($"У Вас {Player.Mistakes} ошибок.");

                    Console.Write("Использованные буквы: ");
                    for (int i = 0; i < Player.UsedLetters.Count; i++)
                    {
                        Console.Write($"{Player.UsedLetters[i]} ");
                    }

                    Console.WriteLine($"\nЗагаданное слово: {GuessWord.VisibleWord} ");
                    Console.Write("Введите букву: ");

                    string userInput = Console.ReadLine();

                    bool IsChar = char.TryParse(userInput, out char letter);
                    bool IsRussianLetter = letter >= 'А' && letter <= 'я';
                    bool IsLetterUsed = Player.UsedLetters.Contains(letter);

                    if (IsChar && IsRussianLetter && !IsLetterUsed)
                    {       
                        Player.UsedLetters.Add(letter);

                        bool HasLetter = GuessWord.HasLetter(letter);
                        if (HasLetter)
                        {
                            GuessWord.OpenLettersInHiddenWord(letter);
                        }
                        else
                        {
                            Player.AddMistake();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nВвод неверен!\nНажмите любую клавишу...");
                        Console.ReadKey();
                    }
                }

                if (GuessWord.IsWordSolved)
                {
                    Console.Clear();
                    Console.WriteLine("Вы выиграли.");
                    Console.WriteLine($"Загаданное слово - {GuessWord.GetHiddenWord()}");
                    Console.WriteLine("Нажмите любую клавишу...");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("К сожалению Вы проиграли.");
                    Console.WriteLine($"Было загадано слово - {GuessWord.GetHiddenWord()}");
                    Console.WriteLine("Нажмите любую клавишу...");
                }
                Console.ReadKey();
            }
        }
    }
}
