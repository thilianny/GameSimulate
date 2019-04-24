using System;
using GameSimulate.Interfaces;

namespace GameSimulate.Hockey
{
    public class HockeyGame : IGame
    {
        public HockeyGame(DateTime date)
        {
            Date = date;
        }

        public void Simulate()
        {
            Console.WriteLine($"{Date:dd MMMM yyyy}: hockey game played");
        }

        public DateTime Date { get; }
    }
}