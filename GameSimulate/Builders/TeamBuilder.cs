using GameSimulate.Abstractions;

namespace GameSimulate.Builders
{
    public abstract class TeamBuilder : ParticipantBuilder<Team, TeamBuilder>
    {
        public TeamBuilder Test()
        {
            return this;
        }
        
        protected override TeamBuilder BuilderInstance => this;
    }
}
