using System.Reflection.Metadata.Ecma335;
using GameSimulate.Builders;
using GameSimulate.Interfaces;

namespace GameSimulate.Implementations.Football
{
    public class FootballGameBuilder : TeamGameBuilder
    {
        internal FootballGameBuilder()
        {
            
        }

        public override ITeamGame Build(ITeam home, ITeam away)
        {
            return CheckTeamTypes(home, away) ? new FootballGame(Date, home, away) : null;
        }
    }
}