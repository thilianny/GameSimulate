using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using GameSimulate.Abstractions;
using GameSimulate.Interfaces;
using GameSimulate.Sessions;

namespace GameSimulate.Builders
{
    public abstract class TeamBuilder : ParticipantBuilder<Team, TeamBuilder>
    {
        public TeamBuilder Test()
        {
            return this;
        }
        
        protected override TeamBuilder BuilderInstance => this;
        
        public abstract Team Build(string name, IEnumerable<Player> roster);
    }
}
