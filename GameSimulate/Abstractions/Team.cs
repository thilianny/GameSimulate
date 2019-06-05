using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GameSimulate.Enums;

namespace GameSimulate.Abstractions
{
    public abstract class Team : Participant
    {
        // team with roster
        protected Team(string name, string country, string city, IEnumerable<Player> roster) : base(name, country, city)
        {
            Roster = roster.ToList();
            Power = !Roster.Any() ? 0 : Roster.Sum(player => player.Power) / Roster.Count();
        }
        
        // team without roster (explicit power set)
        protected Team(string name, string country, string city, int power) : base(name, country, city)
        {
            Power = power;
        }

        private void SignPlayer(Player player)
        {
            Roster.Add(player);
        }
        
        public List<Player> Roster { get; }
    }
}