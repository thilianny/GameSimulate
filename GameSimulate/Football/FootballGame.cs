using System;
using GameSimulate.Interfaces;

namespace GameSimulate.Football
{
    public class FootballGame : ITeamGame<FootballTeam>
    {        
        public DateTime Start { get; }
        
        public FootballTeam Home { get; }
        public FootballTeam Away { get; }
        
        public FootballGame(DateTime start, FootballTeam home, FootballTeam away)
        {
            Start = start;
            Home = home;
            Away = away;
        }
        
        public void Simulate()
        {
            Console.WriteLine("FOOTBALL GAME PLAYED");
        }
    }
}