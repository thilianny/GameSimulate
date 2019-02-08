using System;
using GameSimulate.Interfaces;

namespace GameSimulate.Football
{
    public class FootballGame : ITeamGame
    {
        public FootballGame(int id, DateTime start, ITeam home, ITeam away)
        {
            Id = id;
            Start = start;
            Home = home;
            Away = away;
        }

        public int Id { get; }
        
        public DateTime Start { get; }
        
        public ITeam Home { get; }
        public ITeam Away { get; }
        
        public void Simulate()
        {
            Home.Move();
            Away.Move();
            Console.WriteLine("FOOTBALL GAME PLAYED");
        }
    }
}