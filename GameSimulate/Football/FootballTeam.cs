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
        public string Abbreviation { get; }
        public int Power { get; }
        
        private readonly List<Footballer> _roster = new List<Footballer>();
        
        public ReadOnlyCollection<Footballer> Roster => _roster.AsReadOnly();

        public FootballTeam(string name, string abbreviation, int power)
        {
            Name = name;
            Abbreviation = abbreviation;
            Power = power;
            
            // roster auto generation based on incoming power?
        }

        public FootballTeam(string name, string abbreviation, List<Footballer> roster)
        {
            Name = name;
            Abbreviation = abbreviation;
            
            _roster = roster;

            Power = _roster.Sum(x => x.Power) / _roster.Count();

        }
        
        public void Move()
        {
            Console.WriteLine($"football team {Name} attacks!");
        }
    }
}