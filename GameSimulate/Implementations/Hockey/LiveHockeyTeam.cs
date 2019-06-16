using System.Collections.Generic;
using System.Linq;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.Hockey
{
    public class LiveHockeyTeam : LiveTeam<LiveHockeyPlayer>
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
                if (!_lineup.Any()) return _shots;
                return _lineup.Sum(p => p.Shots) / _lineup.Count;
            }
        }
    }
}