using System.Collections.Generic;
using System.Linq;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.Football
{
    public class LiveFootballTeam : LiveTeam
    {
        public LiveFootballTeam(Team team) : base(team)
        {
            var lineup = new List<LiveFootballPlayer>();
            foreach (var player in team.Roster)
                lineup.Add(new LiveFootballPlayer(player));
            _lineup = lineup;
        }

        private int _shots = 0;

        public int Shots
        {
            get
            {
                var lineup = (List<LiveFootballPlayer>) _lineup;
                return !lineup.Any() ? _shots : lineup.Sum(p => p.Shots);
            }
        }
    }
}