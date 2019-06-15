using System;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.Football
{
    public class FootballGame : TeamGame
    {
        public FootballGame(LiveTeam home, LiveTeam away, DateTime? date = null) : base(home, away, date)
        {
        }

        internal override void Simulate()
        {
            throw new NotImplementedException();
        }
    }
}