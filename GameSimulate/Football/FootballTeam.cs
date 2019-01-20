using System;
using GameSimulate.Interfaces;

namespace GameSimulate.Football
{
    public class FootballTeam : IParticipant
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Power { get; set; }
        public int Goals { get; set; } = 0;

        public FootballTeam(int id, string title, int power)
        {
            Id = id;
            Title = title;
            Power = power;
        }
        
        public void Move()
        {
            Console.WriteLine($"football team {Title} attacks!");
        }

        public void AnotherAction()
        {
            
        }
    }
}