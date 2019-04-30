using GameSimulate.Hockey;
using GameSimulate.Interfaces;

namespace GameSimulate.Builders
{
    public class HockeyPlayerBuilder : PlayerBuilder
    {
        public override IPlayer Build() => new HockeyPlayer(_name, _power, _country, _birthdate);
    }
}