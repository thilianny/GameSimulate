using System.Collections.ObjectModel;

namespace GameSimulate.Interfaces
{
    public interface IParticipantList
    {
        ReadOnlyCollection<IParticipant> Participants { get; }
    }
}