using System;
using System.Collections.Generic;
using System.Linq;
using GameSimulate.Enums;
using GameSimulate.Implementations.Football;
using GameSimulate.Implementations.FormulaOne;
using GameSimulate.Implementations.Hockey;
using GameSimulate.Interfaces;

namespace GameSimulate.Builders
{
    public class RaceBuilder : GameBuilder
    {
        internal RaceBuilder()
        {
            
        }

        public IRace Build(RacingSport sport, IEnumerable<IPlayer> participants)
        {
            switch (sport)
            {
                case RacingSport.FormulaOne:
                    return new FormulaOneRace(Date, participants.Where(participant => participant is FormulaOnePlayer));
                case RacingSport.Biathlon:
                    return null;
                default:
                    throw new ArgumentOutOfRangeException(nameof(sport), sport, null);
            }
        }
    }
}