using System.Collections.Generic;
using System.Linq;
using GameSimulate.Football;
using GameSimulate.Hockey;
using GameSimulate.Interfaces;

namespace GameSimulate.Builders
{
    public class HockeyTeamBuilder : TeamBuilder
    {
        public override ITeam Build(int power) => new HockeyTeam(Name, power, Country, City);

        public override ITeam Build(IEnumerable<IPlayer> roster) =>
            new HockeyTeam(Name, Country, City, roster.Where(player => player is HockeyPlayer));
    }
}