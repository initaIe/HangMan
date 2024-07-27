namespace HangMan
{
    public class HangManGame
    {
        private Player _player;
        private GuessWord _word;
        private HandleInput _handleInput;
        private Gallow _gallow;

        private HangManGame()
        {
            _player = new();
            _word = new();
            _handleInput = new();
            _gallow = new();
        }

        private Status GameStatus
        {
            get => (_player.IsPlayerLose || _word.IsWordSolved) ? Status.IsEnded : Status.InProcess;
        }
        private Result GameResult
        {
            get => _player.IsPlayerLose ? Result.PlayerLost :
                      _word.IsWordSolved ? Result.PlayerWin :
                      Result.Underfined;
        }
        private enum Status
        {
            IsEnded,
            InProcess
        }
        private enum Result
        {
            PlayerLost,
            PlayerWin,
            Underfined
        }

        public static void StartGame()
        {
            while (true)
            {
                HangManGame newGame = new();
                while (newGame.GameStatus == Status.InProcess)
                {
                    Console.Clear();
                    newGame._gallow.DisplayGallow(newGame._player.Mistakes);
                    newGame._player.ShowUsedLetters();
                    newGame._word.PrintVisibleWord();
                    newGame._handleInput.GetUserInput(out char letter);

                    if (!newGame._player.IsUsedLetter(letter))
                    {
                        newGame._player.AddUsedLetter(letter);
                        if (newGame._word.HasLetter(letter))
                            newGame._word.OpenLetterInHiddenWord(letter);
                        else
                            newGame._player.AddMistake();
                    }
                }
                newGame.PrintEndGameText();
            }
        }

        private void PrintEndGameText()
        {
            if (GameResult == Result.PlayerWin)
            {
                Console.Clear();
                Console.WriteLine("Вы выиграли");
                Console.WriteLine($"Загаданное слово: {_word.HiddenWord}");
                Console.WriteLine("Нажмите любую клавишу чтобы начать новую игру...");
                Console.ReadKey();
            }
            if (GameResult == Result.PlayerLost)
            {
                Console.Clear();
                Console.WriteLine("Вы проиграли");
                Console.WriteLine($"Загаданное слово: {_word.HiddenWord}");
                Console.WriteLine("Нажмите любую клавишу чтобы начать новую игру...");
                Console.ReadKey();
            }
        }
    }
}
