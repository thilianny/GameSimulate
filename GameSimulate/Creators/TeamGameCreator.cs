using System;
using GameSimulate.Abstractions;
using GameSimulate.Builders;
using GameSimulate.Interfaces;

namespace GameSimulate.Creators
{
    public class TeamGameCreator
    {
        internal TeamGameCreator()
        {
            
        }
        
        public TeamGameBuilder InitializeBuilder(ITeamSport sport)
        {
            var sportName = sport.GetType().Name;
            return (TeamGameBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}GameBuilder"), true);
        }

        public TeamGame Create(Team home, Team away, DateTime? date = null)
        {
            var sportName = home.GetType().Name.Replace("Team", "");
            if (home.GetType() != away.GetType()) return null;

            var builder = (TeamGameBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}GameBuilder"), true);
            return builder.SetDate(date).Build(home, away);
        }
    }
}