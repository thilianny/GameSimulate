using GameSimulate.Abstractions;

namespace GameSimulate.Builders
{
    public abstract class
        TeamGameBuilder<TLivePlayer> : GameBuilder<TeamGame<TLivePlayer>, TeamGameBuilder<TLivePlayer>>
        where TLivePlayer : LivePlayer
    {
        protected override TeamGameBuilder<TLivePlayer> BuilderInstance => this;

        public abstract TeamGame<TLivePlayer> Build(Team home, Team away);
    }


}