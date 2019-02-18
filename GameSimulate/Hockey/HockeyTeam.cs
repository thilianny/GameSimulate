using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GameSimulate.Interfaces;

namespace GameSimulate.Hockey
{
    public class HockeyTeam : ITeam<HockeyPlayer>
    {
        public string Name { get; }
        public string Abbreviation { get; }
        public int Power { get; }
        
        private readonly List<HockeyPlayer> _roster = new List<HockeyPlayer>();
        
        public ReadOnlyCollection<HockeyPlayer> Roster => _roster.AsReadOnly();

        public HockeyTeam(string name, string abbreviation, int power)
        {
            Name = name;
            Abbreviation = abbreviation;
            Power = power;
            
            // roster auto generation based on incoming power?
        }

        public HockeyTeam(string name, string abbreviation, List<HockeyPlayer> roster)
        {
            Name = name;
            Abbreviation = abbreviation;
            
            _roster = roster;

            Power = _roster.Sum(x => x.Power) / _roster.Count();

        }
        
        public void Move()
        {
            Console.WriteLine($"hockey team {Name} attacks!");
        }
    }
}