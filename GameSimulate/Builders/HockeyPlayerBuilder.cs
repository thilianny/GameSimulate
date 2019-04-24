using GameSimulate.Hockey;
using GameSimulate.Interfaces;

namespace GameSimulate.Builders
{
    public class HockeyPlayerBuilder : PlayerBuilder
    {
        public override IPlayer Create() => new HockeyPlayer(_name, _power, _country, _birthdate);
    }
}