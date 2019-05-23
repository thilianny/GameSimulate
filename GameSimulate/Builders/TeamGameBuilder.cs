using System;
using System.Reflection;
using GameSimulate.Implementations.Football;
using GameSimulate.Implementations.Hockey;
using GameSimulate.Interfaces;

namespace GameSimulate.Builders
{
    public class TeamGameBuilder : GameBuilder
    {

        internal TeamGameBuilder()
        {
            
        }

        public ITeamGame Build(ITeam home, ITeam away)
        {
            if (home.GetType() != away.GetType())
                return null;

            switch (home)
            {
                case FootballTeam _:
                    return new FootballGame(Date, home, away);
                case HockeyTeam _:
                    return new HockeyGame(Date, home, away);
                default:
                    return null;
            }
        }
    }
}