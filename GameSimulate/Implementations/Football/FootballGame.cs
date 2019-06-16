using System;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.Football
{
    public class FootballGame : TeamGame<LiveFootballPlayer>
    {
        public FootballGame(LiveFootballTeam home, LiveFootballTeam away, DateTime? date = null) : base(home, away,
            date)
        {
        }

        internal override void Simulate()
        {
            throw new NotImplementedException();
        }
    }
}