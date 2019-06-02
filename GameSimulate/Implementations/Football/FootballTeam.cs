using System.Collections.Generic;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.Football
{
    public class FootballTeam : Team
    {
        internal FootballTeam(string name, string country, string city, IEnumerable<Player> roster) : base(name, country, city, roster)
        {
        }

        internal FootballTeam(string name, string country, string city, int power) : base(name, country, city, power)
        {
        }
    }
}