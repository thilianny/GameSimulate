using System.Collections.Generic;
using System.Linq;
using GameSimulate.Builders;
using GameSimulate.Enums;
using GameSimulate.Factories;
using GameSimulate.Interfaces;

namespace GameSimulate.Football
{
    public class FootballPlayerFactory : PlayerFactory
    {
        public override IPlayerBuilder Create() =>
            new FootballPlayerBuilder();
    }
}