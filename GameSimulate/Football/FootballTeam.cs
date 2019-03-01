using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GameSimulate.Interfaces;

namespace GameSimulate.Football
{
    public sealed class FootballTeam : ITeam<Football>
    {
        public string Name { get; }
        public int Power { get; }

        private readonly List<ISportsman<Football>> _roster;

        
        public ReadOnlyCollection<ISportsman<Football>> Roster => _roster.AsReadOnly();

        public FootballTeam(string name, int power)
        {
            Name = name;
            Power = power;
            
            // roster auto generation based on incoming power?
            _roster = new List<ISportsman<Football>>();
        }

        public FootballTeam(string name, IEnumerable<Footballer> roster)
        {
            Name = name;
            foreach (var f in roster)
                _roster.Add(f);
            //_roster = roster.ToList();

            Power = _roster.Sum(x => x.Power) / _roster.Count();

        }
        
        public void Move()
        {
            Console.WriteLine($"football team {Name} attacks!");
        }
    }
}