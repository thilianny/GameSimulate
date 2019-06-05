using System.Collections.Generic;
using GameSimulate.Abstractions;
using GameSimulate.Creators;

namespace GameSimulate.Sessions
{
    public class TeamSession : Session
    {
        public List<Team> Teams { get; }
        
        public TeamCreator TeamCreator { get; }
        public Contractor Contractor { get; }

        internal TeamSession()
        {
            TeamCreator = new TeamCreator(this);
            Contractor = new Contractor(this);

            Teams = new List<Team>();
        }

    }
}