using System.Collections.Generic;
using System.Linq;
using GameSimulate.Abstractions;
using GameSimulate.Builders;
using GameSimulate.Sessions;

namespace GameSimulate.Implementations.Hockey
{
    public class HockeyTeamBuilder : TeamBuilder
    {
        internal HockeyTeamBuilder()
        {
            
        }

        public override Team Build(string name, int power)
        {
            var team = new HockeyTeam(name, Country, City, power);
            ((TeamSession) Session)?.Teams.Add(team);
            return team;
        }

        public override Team Build(string name, IEnumerable<Player> roster)
        {
            var team = new HockeyTeam(name, Country, City, roster.Where(player => player is HockeyPlayer));
            ((TeamSession) Session)?.Teams.Add(team);
            return team;
        }
    }
}