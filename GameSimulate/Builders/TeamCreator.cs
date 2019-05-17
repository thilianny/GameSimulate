using System;
using GameSimulate.Enums;
using GameSimulate.Interfaces;

namespace GameSimulate.Builders
{
    public class TeamCreator
    {
        internal TeamCreator()
        {
            
        }
        
        public ITeam CreateSimple(Sport sport, string name, int power)
        {
            var sportName = Enum.GetName(typeof(Sport), sport);
            var builder = (TeamBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Builders.{sportName}TeamBuilder"));

            return builder.SetName(name).Build(power);
        }
        
        public TeamBuilder InitializeBuilder(Sport sport)
        {
            var sportName = Enum.GetName(typeof(Sport), sport);
            return (TeamBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Builders.{sportName}TeamBuilder"));
        }
    }
}