using GameSimulate.Abstractions;
using GameSimulate.Builders;

namespace GameSimulate.Implementations.Hockey
{
    public class HockeyGameBuilder : TeamGameBuilder
    {
        internal HockeyGameBuilder()
        {
            
        }

        public override TeamGame Build(Team home, Team away) =>
            new HockeyGame(new LiveHockeyTeam(home), new LiveHockeyTeam(away), Date);
    }
}