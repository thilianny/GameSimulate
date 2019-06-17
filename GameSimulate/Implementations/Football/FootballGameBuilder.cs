using GameSimulate.Abstractions;
using GameSimulate.Builders;

namespace GameSimulate.Implementations.Football
{
    public class FootballGameBuilder : TeamGameBuilder
    {
        internal FootballGameBuilder()
        {
            
        }

        public override TeamGame Build(Team home, Team away) =>
            new FootballGame(new LiveFootballTeam(home), new LiveFootballTeam(away), Date);
    }
}