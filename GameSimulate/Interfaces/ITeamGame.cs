using GameSimulate.Football;

namespace GameSimulate.Interfaces
{
    internal interface ITeamGame : ISportEvent
    {
        ITeam Home { get; }
        ITeam Away { get; }
    }
}