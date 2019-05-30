using GameSimulate.Builders;
using GameSimulate.Interfaces;

namespace GameSimulate.Implementations.Hockey
{
    public class HockeyGameBuilder : TeamGameBuilder
    {
        internal HockeyGameBuilder()
        {
            
        }

        public override ITeamGame Build(ITeam home, ITeam away)
        {
            return CheckTeamTypes(home, away) ? new HockeyGame(Date, home, away) : null;
        }
    }

}