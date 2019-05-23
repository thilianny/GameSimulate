using GameSimulate.Builders;
using GameSimulate.Interfaces;

namespace GameSimulate.Implementations.Hockey
{
    public class HockeyPlayerBuilder : PlayerBuilder
    {
        internal HockeyPlayerBuilder()
        {
            
        }
        
        public override IPlayer Build(string name, int power) => new HockeyPlayer(name, power, Country, Birthdate);
    }
}