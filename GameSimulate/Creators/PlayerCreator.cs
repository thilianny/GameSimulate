using System;
using GameSimulate.Builders;
using GameSimulate.Enums;
using GameSimulate.Interfaces;

namespace GameSimulate.Creators
{
    public class PlayerCreator
    {
        private readonly ISport _sport;
        internal PlayerCreator(ISport sport)
        {
            _sport = sport;
        }
        
        public IPlayer CreateSimple(string name, int power)
        {
            var sportName = _sport.GetType().Name;
            var builder = (PlayerBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}PlayerBuilder"), true);

            return builder.Build(name, power);
        }

        public PlayerBuilder InitializeBuilder()
        {
            var sportName = _sport.GetType().Name;
            return (PlayerBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}PlayerBuilder"), true);
        }
    }
}