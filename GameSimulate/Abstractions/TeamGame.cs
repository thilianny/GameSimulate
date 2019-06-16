using System;
using GameSimulate.Builders;
using GameSimulate.Enums;

namespace GameSimulate.Abstractions
{
    public abstract class TeamGame<T> : Game where T : LivePlayer
    {
        protected TeamGame(LiveTeam<T> home, LiveTeam<T> away, DateTime? date = null) : base(date)
        {
            Home = home;
            Away = away;
        }

        public LiveTeam<T> Home { get; }
        public LiveTeam<T> Away { get; }

        internal abstract override void Simulate();
    }
}