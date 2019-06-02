using System;
using System.Collections.Generic;
using GameSimulate.Abstractions;
using GameSimulate.Enums;
using GameSimulate.Implementations.Football;

namespace GameSimulate.Creators
{
    public static class RosterCreator
    {
        public static IEnumerable<Player> InitializeTeamRoster(TeamSport sport)
        {
            var sportName = Enum.GetName(typeof(Sport), sport);
            Type type = Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}Player");
            return new List<type>();
        }
    }
}