using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GameSimulate.Interfaces;

namespace GameSimulate.Implementations.Football
{
    public class FootballTeam : ITeam
    {
        internal FootballTeam(string name, int power, string country, string city)
        {
            Name = name;
            Power = power;
            Country = country;
            City = city;
        }
        
        internal FootballTeam(string name, string country, string city, IEnumerable<IPlayer> roster)
        {
            Name = name;
            Country = country;
            City = city;
            Roster = roster.ToList().AsReadOnly();
            
            Power = !Roster.Any() ? 0 : Roster.Sum(player => player.Power) / Roster.Count();
        }

        public string Name { get; }
        public int Power { get; }
        public string Country { get; }
        public string City { get; }
        public ReadOnlyCollection<IPlayer> Roster { get; }
    }
}