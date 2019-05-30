using System;
using GameSimulate.Builders;
using GameSimulate.Enums;
using GameSimulate.Interfaces;

namespace GameSimulate.Creators
{
    public static class GameCreator
    {
        public static TeamGameBuilder InitializeTeamGameBuilder(TeamSport sport)
        {
            var sportName = Enum.GetName(typeof(Sport), sport);
            return (TeamGameBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}GameBuilder"), true);
        }
        
        public static ITeamGame CreateTeamGame(ITeam home, ITeam away)
        {
            var sportName = home.GetType().Name.Replace("Team", "");
            var builder = (TeamGameBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}GameBuilder"), true);

            return builder.Build(home, away);
        }
    }
}