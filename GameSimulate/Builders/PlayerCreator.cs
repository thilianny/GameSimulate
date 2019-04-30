using System;
using GameSimulate.Enums;
using GameSimulate.Interfaces;

namespace GameSimulate.Builders
{
    public class PlayerCreator
    {
        public IPlayer CreateSimple(Sport sport, string name ,int power)
        {
            var sportName = Enum.GetName(typeof(Sport), sport);
            var builderInstance = (PlayerBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Builders.{sportName}PlayerBuilder"));

            return builderInstance.SetName(name).SetPower(power).Build();
        }

        public PlayerBuilder InitializeBuilder(Sport sport)
        {
            var sportName = Enum.GetName(typeof(Sport), sport);
            return (PlayerBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Builders.{sportName}PlayerBuilder"));
        }
    }
}