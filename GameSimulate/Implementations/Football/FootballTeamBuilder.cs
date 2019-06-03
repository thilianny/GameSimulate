using System.Collections.Generic;
using System.Linq;
using GameSimulate.Abstractions;
using GameSimulate.Builders;
using GameSimulate.Interfaces;

namespace GameSimulate.Implementations.Football
{
    public class FootballTeamBuilder : TeamBuilder
    {
        internal FootballTeamBuilder()
        {
            
        }
        
        public override Team Build(int power) => new FootballTeam(Name, Country, City, power);

        public override Team Build(IEnumerable<Player> roster) => new FootballTeam(Name, Country, City,
            roster.Where(player => player is FootballPlayer));
    }
}