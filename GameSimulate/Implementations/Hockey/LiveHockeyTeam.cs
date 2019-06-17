using System.Collections.Generic;
using System.Linq;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.Hockey
{
    public class LiveHockeyTeam : LiveTeam
    {
        public LiveHockeyTeam(Team team) : base(team)
        {
            var lineup = new List<LiveHockeyPlayer>();
            foreach (var player in team.Roster)
                lineup.Add(new LiveHockeyPlayer(player));
            _lineup = lineup;
            //IEnumerable<LivePlayer> x = new List<LiveHockeyPlayer>();
        }

        private int _shots = 0;

        public int Shots
        {
            get
            {
                var lineup = (List<LiveHockeyPlayer>) _lineup;
                return !lineup.Any() ? _shots : lineup.Sum(p => p.Shots);
            }
        }
    }
}