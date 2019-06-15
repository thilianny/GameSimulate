using GameSimulate.Abstractions;

namespace GameSimulate.Builders
{
    public abstract class TeamGameBuilder : GameBuilder<TeamGame, TeamGameBuilder>
    {
        protected override TeamGameBuilder BuilderInstance => this;

        public abstract TeamGame Build(Team home, Team away);
    }
}