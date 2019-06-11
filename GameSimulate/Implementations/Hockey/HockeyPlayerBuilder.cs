using GameSimulate.Abstractions;
using GameSimulate.Builders;

namespace GameSimulate.Implementations.Hockey
{
    public class HockeyPlayerBuilder : PlayerBuilder
    {   
        internal HockeyPlayerBuilder()
        {
            
        }

        public override Player Build(string name, int power = 0) =>
            new HockeyPlayer(name, power, Country, City, Birthdate);
    }
}