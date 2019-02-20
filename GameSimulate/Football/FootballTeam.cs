using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GameSimulate.Interfaces;

namespace GameSimulate.Football
{
    public sealed class FootballTeam : ITeam<Footballer>
    {
        public string Name { get; }
        public int Power { get; }
        
        private readonly List<Footballer> _roster = new List<Footballer>();
        
        public ReadOnlyCollection<Footballer> Roster => _roster.AsReadOnly();

        public FootballTeam(string name, int power)
        {
            Name = name;
            Power = power;
            
            // roster auto generation based on incoming power?
        }

        public FootballTeam(string name, List<Footballer> roster)
        {
            Name = name;
            
            _roster = roster;

            Power = _roster.Sum(x => x.Power) / _roster.Count();

        }
        
        public void Move()
        {
            Console.WriteLine($"football team {Name} attacks!");
        }
    }
}