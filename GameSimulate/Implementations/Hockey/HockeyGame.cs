using System;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.Hockey
{
    public class HockeyGame : TeamGame<LiveHockeyPlayer>
    {
        public HockeyGame(LiveHockeyTeam home, LiveHockeyTeam away, DateTime? date = null) : base(home, away, date)
        {
        }

        internal override void Simulate()
        {
            throw new NotImplementedException();
        }
    }
}