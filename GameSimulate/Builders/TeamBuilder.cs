using GameSimulate.Abstractions;
using GameSimulate.Enums;

namespace GameSimulate.Builders
{
    public abstract class TeamBuilder : ParticipantBuilder<Team, TeamSport, TeamBuilder>
    {
        public TeamBuilder Test()
        {
            return this;
        }
        
        protected override TeamBuilder BuilderInstance => this;
    }
}
