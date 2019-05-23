using System;
using GameSimulate.Builders;
using GameSimulate.Enums;
using GameSimulate.Interfaces;

namespace GameSimulate.Creators
{
    public static class TeamCreator
    {
        public static ITeam CreateSimple(Sport sport, string name, int power)
        {
            var sportName = Enum.GetName(typeof(Sport), sport);
            var builder = (TeamBuilder) Activator.CreateInstance(
                    Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}TeamBuilder"), true);

            return builder.SetName(name).Build(power);
        }
        
        public static TeamBuilder InitializeBuilder(Sport sport)
        {
            var sportName = Enum.GetName(typeof(Sport), sport);
            return (TeamBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}TeamBuilder"), true);
        }
    }
}