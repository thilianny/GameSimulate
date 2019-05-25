using System;
using System.Collections.Generic;
using GameSimulate.Implementations.Football;
using GameSimulate.Implementations.Hockey;
using GameSimulate.Interfaces;

namespace GameSimulate.Builders
{
    public class GameBuilder
    {
        protected DateTime? Date;

        internal GameBuilder()
        {
            
        }
        
        public GameBuilder SetDate(DateTime date)
        {
            Date = date;
            return this;
        }
        
        public ITeamGame BuildTeamGame(ITeam home, ITeam away)
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

        public IRace BuildRace(IEnumerable<IRacer> participants)
        {
            return null;
        }
    }
}