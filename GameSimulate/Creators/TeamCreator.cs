using System;
using GameSimulate.Builders;
using GameSimulate.Enums;
using GameSimulate.Interfaces;

namespace GameSimulate.Creators
{
    public class TeamCreator
    {
        private readonly ISport _sport;
        internal TeamCreator(ISport sport)
        {
            _sport = sport;
        }
        public ITeam CreateSimple(string name, int power)
        {
            var sportName = _sport.GetType().Name;
            var builder = (TeamBuilder) Activator.CreateInstance(
                    Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}TeamBuilder"), true);

            return builder.SetName(name).Build(power);
        }
        
        public TeamBuilder InitializeBuilder()
        {
            var sportName = _sport.GetType().Name;
            return (TeamBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}TeamBuilder"), true);
        }
    }
}