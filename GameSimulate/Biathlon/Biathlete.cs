using System;
using System.Diagnostics.CodeAnalysis;
using GameSimulate.Interfaces;

namespace GameSimulate.Biathlon
{
    [SuppressMessage("ReSharper", "PossibleLossOfFraction")]
    public class Biathlete : ISportsman
    {
        public int Id { get; }
        public string Name { get; }
        public int Power { get; }

        public int DistancePassed { get; } = 0;

        public TimeSpan Time { get; } = new TimeSpan(0, 0, 0);

        private double _proneSuccess = 0;
        private double _standingSuccess = 0;

        public Biathlete(int id, string name, int power)
        {
            Id = id;
            Name = name;
            Power = power;

            _proneSuccess = power * 0.95;
            _standingSuccess = power * 0.9;
        }
        
        public void Move()
        {
            Console.WriteLine($"biathlete {Name} moves!");
        }

        public void Shoot(ShootingType st)
        {
            Console.WriteLine($"biathlete {Name} shoots!");
            switch (st)
            {
                case ShootingType.Prone:
                    ShootProne();
                    break;
                case ShootingType.Standing:
                    ShootStand();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(st), st, null);
            }
        }

        private static void ShootProne()
        {
            
        }

        private static void ShootStand()
        {
            
        }
    }
}