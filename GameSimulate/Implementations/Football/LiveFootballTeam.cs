using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.Football
{
    public class LiveFootballTeam : LiveTeam
    {
        public LiveFootballTeam(Team team) : base(team)
        {
            foreach (var player in team.Roster)
                _lineup.Add(new LiveFootballPlayer(player));
        }

        private int _shots = 0;

        public int Shots
        {
            get
            {
                var footballLineup = (List<LiveFootballPlayer>)_lineup.Where(p => p is LiveFootballPlayer);
                if (!footballLineup.Any()) return _shots;
                return footballLineup.Sum(p => p.Shots) / footballLineup.Count;
            }
        }
    }
}