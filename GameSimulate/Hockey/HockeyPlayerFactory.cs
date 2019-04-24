using System.Collections.Generic;
using System.Linq;
using GameSimulate.Builders;
using GameSimulate.Factories;
using GameSimulate.Football;
using GameSimulate.Interfaces;

namespace GameSimulate.Hockey
{
    public class HockeyPlayerFactory : PlayerFactory
    {
        public override IPlayerBuilder Create() =>
            new HockeyPlayerBuilder();
    }
}