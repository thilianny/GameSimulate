using System.Collections.Generic;
using System.Linq;
using GameSimulate.Abstractions;
using GameSimulate.Enums;

namespace GameSimulate.Implementations.Hockey
{
    public class HockeyTeam : Team
    {
        internal HockeyTeam(string name, int power, string country, string city) : base(name, power, country, city)
        {
            Sport = TeamSport.Hockey;
        }
        
        public override void AttachRoster(IEnumerable<Player> roster)
        {
            _roster.AddRange(roster.Where(p => p is HockeyPlayer));
        }
        
        public override void Sign(Player player)
        {
            if (player is HockeyPlayer)
                _roster.Add(player);
        }
    }
}