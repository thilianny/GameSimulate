using System;
using GameSimulate.Interfaces;

namespace GameSimulate.Football
{
    public class FootballGame : ITeamGame
    {
        public FootballGame(DateTime date)
        {
            Date = date;
        }

        public void Simulate()
        {
            Console.WriteLine($"{Date:dd MMMM yyyy}: football game played");
        }

        public DateTime Date { get; }
        public ITeam Home { get; set; }
        public ITeam Away { get; set; }
    }
}