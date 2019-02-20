using System.Collections.Generic;
using System.Collections.ObjectModel;
using GameSimulate.Football;

namespace GameSimulate.Interfaces
{
    public interface ITeam<T> : IParticipant where T : ISportsman
    {
        ReadOnlyCollection<T> Roster { get; }
    }
}