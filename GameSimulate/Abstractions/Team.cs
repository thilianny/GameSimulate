using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace GameSimulate.Abstractions
{
    public abstract class Team : Participant
    {
        // team with roster
        protected Team(string name, string country, string city, IEnumerable<Player> roster) : base(name, country, city)
        {
            Roster = roster.ToList().AsReadOnly();
            Power = !Roster.Any() ? 0 : Roster.Sum(player => player.Power) / Roster.Count();
        }
        
        // team without roster (explicit power set)
        protected Team(string name, string country, string city, int power) : base(name, country, city)
        {
            Power = power;
        }
        
        public ReadOnlyCollection<Player> Roster { get; }
    }
}