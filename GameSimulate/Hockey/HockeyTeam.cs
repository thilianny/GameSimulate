using System;
using GameSimulate.Interfaces;

namespace GameSimulate.Hockey
{
    public class HockeyTeam : IParticipant
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Power { get; set; }
        public int Goals { get; set; } = 0;
        
        public HockeyTeam(int id, string title, int power)
        {
            Id = id;
            Title = title;
            Power = power;
        }

        public void Move()
        {
            Console.WriteLine($"hockey team {Title} attacks!");
        }
    }
}