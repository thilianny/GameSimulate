using System;
using GameSimulate.Builders;
using GameSimulate.Enums;
using GameSimulate.Interfaces;

namespace GameSimulate.Creators
{
    public static class PlayerCreator
    {   
        public static IPlayer Create(Sport sport, string name, int power)
        {
            var sportName = Enum.GetName(typeof(Sport), sport);
            var builder = (PlayerBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}PlayerBuilder"), true);

            return builder.Build(name, power);
        }

        public static PlayerBuilder InitializeBuilder(Sport sport)
        {
            var sportName = Enum.GetName(typeof(Sport), sport);
            return (PlayerBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}PlayerBuilder"), true);
        }
    }
}