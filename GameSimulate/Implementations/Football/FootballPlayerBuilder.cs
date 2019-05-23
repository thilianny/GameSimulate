using GameSimulate.Builders;
using GameSimulate.Interfaces;

namespace GameSimulate.Implementations.Football
{
    public class FootballPlayerBuilder : PlayerBuilder
    {
        internal FootballPlayerBuilder()
        {
            
        }

        public override IPlayer Build(string name, int power) => new FootballPlayer(name, power, Country, Birthdate);
    }
}