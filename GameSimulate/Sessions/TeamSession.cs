using System.Collections.Generic;
using GameSimulate.Abstractions;
using GameSimulate.Creators;

namespace GameSimulate.Sessions
{
    public sealed class TeamSession : Session
    {
        public List<Team> Teams { get; }
        
        public TeamCreator TeamCreator { get; private set; }
        public Contractor Contractor { get; private set; }

        internal TeamSession()
        {
            Teams = new List<Team>();
        }
        
        internal override void InitializeCreators()
        {
            PlayerCreator = new PlayerCreator(this);
            TeamCreator = new TeamCreator(this);
            Contractor = new Contractor(this);
        }

    }
}