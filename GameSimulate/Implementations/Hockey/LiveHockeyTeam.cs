using System.Collections.Generic;
using System.Linq;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.Hockey
{
    public class LiveHockeyTeam : LiveTeam
    {
        public LiveHockeyTeam(Team team) : base(team)
        {
            foreach (var player in team.Roster)
                _lineup.Add(new LiveHockeyPlayer(player));
        }

        private int _shots = 0;

        public int Shots
        {
            get
            {
                var hockeyLineup = (List<LiveHockeyPlayer>)_lineup.Where(p => p is LiveHockeyPlayer);
                if (!hockeyLineup.Any()) return _shots;
                return hockeyLineup.Sum(p => p.Shots) / hockeyLineup.Count;
            }
        }
    }
}