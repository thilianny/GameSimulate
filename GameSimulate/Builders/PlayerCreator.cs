using System;
using GameSimulate.Enums;
using GameSimulate.Interfaces;

namespace GameSimulate.Builders
{
<<<<<<< HEAD
    public class PlayerDirector
    {
        private PlayerBuilder _builderInstance;
        public IPlayer CreateSimplePlayer(Sport sport, string name ,int power)
        {
            var sportName = Enum.GetName(typeof(Sport), sport);
            _builderInstance = (PlayerBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Builders.{sportName}PlayerBuilder"));

            return _builderInstance.SetName(name).SetPower(power).Build();
=======
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
>>>>>>> master
        }
    }
}