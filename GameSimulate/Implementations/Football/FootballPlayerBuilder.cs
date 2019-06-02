using GameSimulate.Abstractions;
using GameSimulate.Builders;

namespace GameSimulate.Implementations.Football
{
    public class FootballPlayerBuilder : PlayerBuilder
    {
        internal FootballPlayerBuilder()
        {
            
        }

        public override Player Build(string name, int power) => new FootballPlayer(name, power, Country, Birthdate);
    }
}