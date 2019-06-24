using System;
using GameSimulate.Abstractions;
using GameSimulate.Builders;
using GameSimulate.Interfaces;

namespace GameSimulate.Creators
{
    public static class TeamCreator
    {   

        public static Team Create(ITeamSport sport, string name, int power = 0)
        {
            var sportName = sport.GetType().Name;
            var builder = (TeamBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}TeamBuilder"), true);
            return builder.Build(name, power);
        }

        public static TeamBuilder InitializeBuilder(ITeamSport sport)
        {
            var sportName = sport.GetType().Name;
            return (TeamBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}TeamBuilder"), true);
        }
    }
}