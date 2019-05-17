using System.Collections.Generic;
using System.Linq;
using GameSimulate.Football;
using GameSimulate.Interfaces;

namespace GameSimulate.Builders
{
    public class FootballTeamBuilder : TeamBuilder
    {
        public override ITeam Build(int power) => new FootballTeam(Name, power, Country, City);

        public override ITeam Build(IEnumerable<IPlayer> roster) => new FootballTeam(Name, Country, City,
            roster.Where(player => player is FootballPlayer));
    }
}