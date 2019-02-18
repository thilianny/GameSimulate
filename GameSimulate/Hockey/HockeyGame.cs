using System;
using GameSimulate.Interfaces;

namespace GameSimulate.Hockey
{
    public class HockeyGame : ITeamGame<HockeyTeam>
    {        
        public DateTime Start { get; }
        
        public HockeyTeam Home { get; }
        public HockeyTeam Away { get; }
        
        public HockeyGame(DateTime start, HockeyTeam home, HockeyTeam away)
        {
            Start = start;
            Home = home;
            Away = away;
        }

        public void Simulate()
        {
            Console.WriteLine("HOCKEY GAME PLAYED");
        }
    }
}