using System;
using System.Reflection.Metadata.Ecma335;
using GameSimulate.Abstractions;
using GameSimulate.Builders;
using GameSimulate.Enums;
using GameSimulate.Implementations.Football;

namespace GameSimulate.Creators
{
    public class TeamGameCreator
    {
        internal TeamGameCreator()
        {
            
        }
        
        public TeamGameBuilder<LivePlayer> InitializeBuilder(TeamSport sport)
        {
            var sportName = Enum.GetName(typeof(Sport), sport);
            return (TeamGameBuilder<LivePlayer>) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}GameBuilder"), true);
        }

        public TeamGame<LivePlayer> Create(Team home, Team away, DateTime? date = null)
        {
            var sportName = home.GetType().Name.Replace("Team", "");
            var awaySportName = away.GetType().Name.Replace("Team", "");
            if (sportName != awaySportName) return null;

            var builder = (TeamGameBuilder<LivePlayer>) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}GameBuilder"), true);
            return builder.SetDate(date).Build(home, away);
        }
    }
}