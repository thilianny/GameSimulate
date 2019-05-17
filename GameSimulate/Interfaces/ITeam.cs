using System.Collections.ObjectModel;

namespace GameSimulate.Interfaces
{
    public interface ITeam : IParticipant
    {
        string City { get; }
        ReadOnlyCollection<IPlayer> Roster { get; }
    }
}