using System.Collections.ObjectModel;

namespace GameSimulate.Interfaces
{
    public interface IRace : ISportEvent
    {
        ReadOnlyCollection<IParticipant> Participants { get; }
    }
}