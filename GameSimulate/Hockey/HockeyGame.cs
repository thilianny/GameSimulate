using System;
using GameSimulate.Interfaces;

namespace GameSimulate.Hockey
{
    public class HockeyGame : ITeamGame<HockeyPlayer>
    {        
        public DateTime Start { get; }

        public ITeam<HockeyPlayer> Home { get; }
        public ITeam<HockeyPlayer> Away { get; }
        
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