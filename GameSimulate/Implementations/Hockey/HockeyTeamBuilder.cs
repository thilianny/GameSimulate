using System.Collections.Generic;
using System.Linq;
using GameSimulate.Builders;
using GameSimulate.Interfaces;

namespace GameSimulate.Implementations.Hockey
{
    public class HockeyTeamBuilder : TeamBuilder
    {
        internal HockeyTeamBuilder()
        {
            
        }
        
        public override ITeam Build(int power) => new HockeyTeam(Name, power, Country, City);

        public override ITeam Build(IEnumerable<IPlayer> roster) =>
            new HockeyTeam(Name, Country, City, roster.Where(player => player is HockeyPlayer));
    }
}