using HangMan.Common.WordGeneration;
using HangMan.Common.WordGeneration.FromFile;

namespace HangMan.Common
{
    public class HangManGame
    {
        private Player _player = new();
        private GuessWord _word;
        private InputHandler _inputHandler = new();
        private Gallow _gallow = new();

        private WordGeneratorService _wordGeneratorService;

        public HangManGame(IWordGenerator wordGenerator)
        {
            _wordGeneratorService = new(wordGenerator);
            _word = new(_wordGeneratorService.Generate());
        }

        private Status GameStatus =>
            _player.IsPlayerLose || _word.IsWordSolved ? Status.IsEnded : Status.IsRunning;

        private Result GameResult => _player.IsPlayerLose ? Result.PlayerLost :
                                     _word.IsWordSolved ? Result.PlayerWin :
                                     Result.Underfined;

        private enum Status
        {
            IsEnded,
            IsRunning
        }
        private enum Result
        {
            PlayerLost,
            PlayerWin,
            Underfined
        }

        public void Start()
        {
            while (GameStatus == Status.IsRunning)
            {
                Console.Clear();
                _gallow.DisplayGallow(_player.Mistakes);
                _player.ShowUsedLetters();
                _word.PrintVisibleWord();
                char letter = _inputHandler.GetInput();

                if (!_player.IsUsedLetter(letter))
                {
                    _player.AddUsedLetter(letter);
                    if (_word.HasLetter(letter))
                        _word.OpenLetterInHiddenWord(letter);
                    else
                        _player.AddMistake();
                }
            }
            DisplayEndGameText();
        }

        private void DisplayEndGameText()
        {
            Console.Clear();
            Console.WriteLine(GameResult == Result.PlayerWin ? "Поздравляю Вы выиграли!" : "К сожалению Вы проиграли");
            Console.WriteLine($"Загаданное слово: {_word.HiddenWord}");
            Console.WriteLine("Нажмите любую клавишу чтобы начать новую игру...");
            Console.ReadKey();
        }
    }
}
