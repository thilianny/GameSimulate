using System;
using GameSimulate.Interfaces;

namespace GameSimulate.Implementations.Hockey
{
    public class HockeyGame : ITeamGame
    {
        internal HockeyGame(DateTime? date, ITeam home, ITeam away)
        {
            Date = date;
            Home = home;
            Away = away;
        }

        public void Simulate()
        {
            Console.WriteLine($"Hockey game played");
        }

        public DateTime? Date { get; }
        public ITeam Home { get; }
        public ITeam Away { get; }
    }
}