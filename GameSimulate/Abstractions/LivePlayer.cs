

namespace GameSimulate.Abstractions
{
    public abstract class LivePlayer
    {
        private Player _player;

        protected LivePlayer(Player player)
        {
            _player = player;
            IsActive = false;
        }

        public string Name => _player.Name;
        public int Power => _player.Power;

        internal bool IsActive;
    }
}