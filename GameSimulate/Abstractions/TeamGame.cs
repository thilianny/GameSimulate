using System;

namespace GameSimulate.Abstractions
{
    public abstract class TeamGame : Game
    {
        protected TeamGame(LiveTeam home, LiveTeam away, DateTime? date = null) : base(date)
        {
            Home = home;
            Away = away;
        }

        public LiveTeam Home { get; }
        public LiveTeam Away { get; }

        internal abstract override void Simulate();
    }
}