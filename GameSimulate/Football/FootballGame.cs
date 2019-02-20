using System;
using GameSimulate.Interfaces;

namespace GameSimulate.Football
{
    public class FootballGame : ITeamGame<Footballer>
    {        
        public DateTime Start { get; }
        public Weather Weather { get; }
        public ITeam<Footballer> Home { get; }
        public ITeam<Footballer> Away { get; }
        
        public FootballGame(DateTime start, FootballTeam home, FootballTeam away, Weather weather)
        {
            Start = start;
            Home = home;
            Away = away;
            Weather = weather;
        }
        
        public void Simulate()
        {
            Console.WriteLine("FOOTBALL GAME PLAYED");
        }
    }
}