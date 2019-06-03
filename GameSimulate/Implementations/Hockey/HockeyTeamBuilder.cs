using System.Collections.Generic;
using System.Linq;
using GameSimulate.Abstractions;
using GameSimulate.Builders;
using GameSimulate.Interfaces;

namespace GameSimulate.Implementations.Hockey
{
    public class HockeyTeamBuilder : TeamBuilder
    {
        internal HockeyTeamBuilder()
        {
            
        }
        
        public override Team Build(int power) => new HockeyTeam(Name, Country, City, power);

        public override Team Build(IEnumerable<Player> roster) => new HockeyTeam(Name, Country, City,
            roster.Where(player => player is HockeyPlayer));
    }
}