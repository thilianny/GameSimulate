using System.Collections.Generic;
using System.Collections.ObjectModel;
using GameSimulate.Football;

namespace GameSimulate.Interfaces
{
    public interface ITeam<T> : IParticipant where T : ISport
    {
        ReadOnlyCollection<ISportsman<T>> Roster { get; }
    }
}