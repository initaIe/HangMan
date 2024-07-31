using HangMan.Common.Interfaces;

namespace HangMan.Common.Classes
{
    public class Game : IGame
    {
        private ISettings _settings;
        private IHistory _history;
        private ISecretWord _secretWord;
        private IPlayer _player;
        private IPresenter _presenter;

        public Game(ISettings settings, IHistory history, ISecretWord secretWord,
                    IPlayer player, IPresenter presenter)
        {
            _settings = settings;
            _history = history;
            _secretWord = secretWord;
            _player = player;
            _presenter = presenter;
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }
    }
}
