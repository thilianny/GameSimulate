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
            if (Home == null || Away == null)
            {
                Console.WriteLine($"Can't start game without two hockey teams.");
                return;
            }

            Console.WriteLine($"{Date:dd MMMM yyyy}: hockey game played");
        }

        public DateTime? Date { get; }
        public ITeam Home { get; }
        public ITeam Away { get; }
    }
}