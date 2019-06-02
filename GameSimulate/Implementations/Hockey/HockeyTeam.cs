using System.Collections.Generic;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.Hockey
{
    public class HockeyTeam : Team
    {
        internal HockeyTeam(string name, string country, string city, IEnumerable<Player> roster) : base(name, country, city, roster)
        {
        }

        internal HockeyTeam(string name, string country, string city, int power) : base(name, country, city, power)
        {
        }
    }
}