using System;
using System.Diagnostics.CodeAnalysis;
using GameSimulate.Interfaces;

namespace GameSimulate.Biathlon
{
    [SuppressMessage("ReSharper", "PossibleLossOfFraction")]
    public class Biathlete : IParticipant
    {
        public int Id { get; }
        public string Title { get; }
        public int Power { get; }

        public int DistancePassed { get; } = 0;

        public TimeSpan Time { get; } = new TimeSpan(0, 0, 0);
        public double ProneChance { get; } = 0;
        public double StandingChanсe { get; } = 0;

        public Biathlete(int id, string title, int power)
        {
            Id = id;
            Title = title;
            Power = power;
            ProneChance = power / 100;
        }
        
        public void Move()
        {
            Console.WriteLine($"biathlete {Title} moves!");
        }

        public void ProneShot()
        {
            Console.WriteLine($"biathlete {Title} shoots prone!");
        }
        
        public void StandingShot()
        {
            Console.WriteLine($"biathlete {Title} shoots standing!");
        }
    }
}