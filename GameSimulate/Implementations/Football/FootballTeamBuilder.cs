using GameSimulate.Abstractions;
using GameSimulate.Builders;

namespace GameSimulate.Implementations.Football
{
    public class FootballTeamBuilder : TeamBuilder
    {
        internal FootballTeamBuilder()
        {
            
        }

        public override Team Build(string name, int power = 0) => new FootballTeam(name, power, Country, City);
    }
}