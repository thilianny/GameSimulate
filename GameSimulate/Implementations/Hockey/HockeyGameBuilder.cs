using GameSimulate.Abstractions;
using GameSimulate.Builders;

namespace GameSimulate.Implementations.Hockey
{
    public class HockeyGameBuilder : TeamGameBuilder<LiveHockeyPlayer>
    {
        internal HockeyGameBuilder()
        {
            
        }

        public override TeamGame<LiveHockeyPlayer> Build(Team home, Team away) =>
            new HockeyGame(new LiveHockeyTeam(home), new LiveHockeyTeam(away), Date);
    }
}