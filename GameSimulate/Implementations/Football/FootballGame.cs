using System;
using GameSimulate.Interfaces;

namespace GameSimulate.Implementations.Football
{
    public class FootballGame : ITeamGame
    {
        internal FootballGame(DateTime? date, ITeam home, ITeam away)
        {
            Date = date;
            Home = home;
            Away = away;
        }

        public void Simulate()
        {
            if (Home == null || Away == null)
            {
                Console.WriteLine($"Can't start game without two football teams.");
                return;
            }
            
            Console.WriteLine($"{Date:dd MMMM yyyy}: football game played");
        }

        public DateTime? Date { get; }
        public ITeam Home { get; }
        public ITeam Away { get; }
    }
}