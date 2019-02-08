using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GameSimulate.Interfaces;

namespace GameSimulate.Football
{
    public class FootballTeam : ITeam
    {
        public int Id { get; }
        public string Name { get; }
        public int Power { get; }
        
        private readonly List<ISportsman> _roster = new List<ISportsman>();
        public ReadOnlyCollection<ISportsman> Roster => _roster.AsReadOnly();


        public void SignContract(ISportsman sportsman)
        {
            if (sportsman is Footballer footballer)
            {
                _roster.Add(footballer);
            }
            else
            {
                throw new ArgumentException("You can sign only footballers to football team.");
            }
        }

        public FootballTeam(int id, int power, string name)
        {
            Id = id;
            Power = power;
            Name = name;
        }
        
        public void Move()
        {
            Console.WriteLine($"football team {Name} attacks!");
        }

        public void AnotherAction()
        {
            
        }
    }
}