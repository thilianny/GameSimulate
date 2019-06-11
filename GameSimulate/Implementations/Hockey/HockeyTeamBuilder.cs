using GameSimulate.Abstractions;
using GameSimulate.Builders;

namespace GameSimulate.Implementations.Hockey
{
    public class HockeyTeamBuilder : TeamBuilder
    {
        internal HockeyTeamBuilder()
        {
            
        }

        public override Team Build(string name, int power = 0) => new HockeyTeam(name, power, Country, City);
    }
}