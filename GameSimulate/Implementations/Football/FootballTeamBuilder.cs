using System.Collections.Generic;
using System.Linq;
using GameSimulate.Abstractions;
using GameSimulate.Builders;
using GameSimulate.Interfaces;
using GameSimulate.Sessions;

namespace GameSimulate.Implementations.Football
{
    public class FootballTeamBuilder : TeamBuilder
    {
        public FootballTeamBuilder()
        {
            
        }

        public override Team Build(string name, int power)
        {
            var team = new FootballTeam(name, Country, City, power);
            ((TeamSession) Session)?.Teams.Add(team);
            return team;
        }

        public override Team Build(string name, IEnumerable<Player> roster)
        {
            var team = new FootballTeam(name, Country, City, roster.Where(player => player is FootballPlayer));
            ((TeamSession) Session)?.Teams.Add(team);
            return team;
        }
    }
}