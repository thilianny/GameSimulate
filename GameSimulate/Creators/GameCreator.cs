using System;
using GameSimulate.Abstractions;
using GameSimulate.Builders;
using GameSimulate.Enums;

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
        
        public static TeamGame CreateTeamGame(Team home, Team away, DateTime? date = null)
        {
            var sportName = home.GetType().Name.Replace("Team", "");
            var awaySportName = away.GetType().Name.Replace("Team", "");
            if (sportName != awaySportName) return null;
            
            var builder = (TeamGameBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}GameBuilder"), true);
            return builder.SetDate(date).Build(home, away);
        }
    }
}