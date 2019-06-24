using System;
using GameSimulate.Abstractions;
using GameSimulate.Builders;
using GameSimulate.Interfaces;

namespace GameSimulate.Creators
{
    public static class PlayerCreator
    {        
        public static Player Create(ISport sport, string name, int power)
        {
            var sportName = sport.GetType().Name;
            var builder = (PlayerBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}PlayerBuilder"), true);
            return builder.Build(name, power);
        }

        public static PlayerBuilder InitializeBuilder(ISport sport)
        {
            var sportName = sport.GetType().Name;
            return (PlayerBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}PlayerBuilder"), true);
        }
    }
}