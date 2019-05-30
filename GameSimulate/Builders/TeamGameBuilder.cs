using System;
using GameSimulate.Exceptions;
using GameSimulate.Interfaces;

namespace GameSimulate.Builders
{
    public abstract class TeamGameBuilder : GameBuilder
    {
        public abstract ITeamGame Build(ITeam home, ITeam away);

        protected static bool CheckTeamTypes(ITeam home, ITeam away)
        {
            if (home.GetType() == away.GetType()) return true;
            
            Console.WriteLine("You should use teams with same types.");
            return false;
        }
    }
}