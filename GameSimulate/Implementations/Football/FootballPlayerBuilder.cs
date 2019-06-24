using GameSimulate.Abstractions;
using GameSimulate.Builders;

namespace GameSimulate.Implementations.Football
{
    public class FootballPlayerBuilder : PlayerBuilder
    {
        internal FootballPlayerBuilder()
        {
            
        }

        public override Player Build(string name, int power = 0) =>
            new FootballPlayer(name, power, Country, City, Birthdate);

    }
}