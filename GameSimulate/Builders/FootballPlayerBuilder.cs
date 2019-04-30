using System;
using System.Collections.Generic;
using GameSimulate.Enums;
using GameSimulate.Football;
using GameSimulate.Interfaces;

namespace GameSimulate.Builders
{
    public class FootballPlayerBuilder : PlayerBuilder
    {
        public override IPlayer Build() => new FootballPlayer(_name, _power, _country, _birthdate);
    }
}