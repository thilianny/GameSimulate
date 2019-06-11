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
                _squad.Add(new LiveFootballPlayer(player));
        }

        private int _shots = 0;

        public int Shots
        {
            get
            {
                var footballSquad = (List<LiveFootballPlayer>)_squad.Where(p => p is LiveFootballPlayer);
                if (!footballSquad.Any()) return _shots;
                return footballSquad.Sum(p => p.Shots) / footballSquad.Count;
            }
        }
    }
}