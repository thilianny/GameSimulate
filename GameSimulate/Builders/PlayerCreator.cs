using System;
using GameSimulate.Enums;
using GameSimulate.Interfaces;

namespace GameSimulate.Builders
{
    public class PlayerDirector
    {
        private PlayerBuilder _builderInstance;
        public IPlayer CreateSimplePlayer(Sport sport, string name ,int power)
        {
            var sportName = Enum.GetName(typeof(Sport), sport);
            _builderInstance = (PlayerBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Builders.{sportName}PlayerBuilder"));

            return _builderInstance.SetName(name).SetPower(power).Build();
        }
    }
}