using GameSimulate.Football;

namespace GameSimulate.Interfaces
{
    internal interface ITeamGame<out T> : ISportEvent
    {
        T Home { get; }
        T Away { get; }
    }
}