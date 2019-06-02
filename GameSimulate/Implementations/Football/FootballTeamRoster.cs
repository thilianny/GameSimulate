using System.Buffers.Text;
using System.Collections.Generic;
using System.Net.Sockets;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.Football
{
    public class FootballTeamRoster : List<FootballPlayer>
    {
        public FootballTeamRoster()
        {
        }
    }
}