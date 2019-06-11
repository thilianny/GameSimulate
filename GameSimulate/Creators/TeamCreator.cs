using System;
using GameSimulate.Abstractions;
using GameSimulate.Builders;
using GameSimulate.Enums;

namespace GameSimulate.Creators
{
    public static class TeamCreator
    {   

        public static Team Create(TeamSport sport, string name, int power = 0)
        {
            var sportName = Enum.GetName(typeof(Sport), sport);
            var builder = (TeamBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}TeamBuilder"), true);
            return builder.Build(name, power);
        }

        public static TeamBuilder InitializeBuilder(TeamSport sport)
        {
            var sportName = Enum.GetName(typeof(Sport), sport);
            return (TeamBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}TeamBuilder"), true);
        }
    }
}