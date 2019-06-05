using System.Reflection.Metadata;
using GameSimulate.Abstractions;
using GameSimulate.Sessions;

namespace GameSimulate.Creators
{
    public class Contractor
    {
        private readonly Session _session;
        //private readonly string _sportName;
        
        internal Contractor(Session session)
        {
            _session = session;
        }

        public void Sign(Team team, Player player)
        {
            player.Team = team;
            team.Roster.Add(player);
        }

        public void Transfer(Team source, Team destination, Player player)
        {
            source.Roster.Remove(player);
            destination.Roster.Add(player);
            player.Team = destination;
        }

        public void Dissolve(Team team, Player player)
        {
            player.Team = null;
            team.Roster.Remove(player);
        }
        
    }
}