using System.Collections.Generic;
using System.Linq;
using GameSimulate.Builders;
using GameSimulate.Interfaces;

namespace GameSimulate.Implementations.Football
{
    public class FootballTeamBuilder : TeamBuilder
    {
        internal FootballTeamBuilder()
        {
            
        }
        
        public override ITeam Build(int power) => new FootballTeam(Name, power, Country, City);

        public override ITeam Build(IEnumerable<IPlayer> roster) => new FootballTeam(Name, Country, City,
            roster.Where(player => player is FootballPlayer));
    }
}