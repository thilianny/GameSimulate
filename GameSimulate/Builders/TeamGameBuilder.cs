using GameSimulate.Abstractions;
using GameSimulate.Enums;

namespace GameSimulate.Builders
{
    public abstract class
        TeamGameBuilder : GameBuilder<TeamGame, TeamSport, TeamGameBuilder>
    {
        protected override TeamGameBuilder BuilderInstance => this;

        public abstract TeamGame Build(Team home, Team away);
    }


}