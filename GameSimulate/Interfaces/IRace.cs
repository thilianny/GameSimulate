using System.Collections.ObjectModel;

namespace GameSimulate.Interfaces
{
    public interface IRace : IGame
    {
        ReadOnlyCollection<IPlayer> Participants { get; }
    }
}