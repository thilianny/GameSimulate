using System;

namespace GameSimulate.Abstractions
{
    public abstract class TeamGame : Game
    {
        public TeamGame(DateTime? date) : base(date)
        {
        }

        //public Team Home { get; }

        internal abstract override void Simulate();
    }
}