using System;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.Hockey
{
    public class HockeyGame : TeamGame
    {
        internal HockeyGame(LiveTeam home, LiveTeam away, DateTime? date = null) : base(home, away, date)
        {
        }
        
        protected override void RosterSimulate()
        {
            Console.WriteLine($"Simulated hockey game between {Home.Name} and {Away.Name}. Used rosters");
        }

        protected override void PowerSimulate()
        {
            Console.WriteLine($"Simulated hockey game between {Home.Name} and {Away.Name}. Used only powers");
        }
    }
}