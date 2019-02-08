using System.Collections.Generic;
using System.Collections.ObjectModel;
using GameSimulate.Football;

namespace GameSimulate.Interfaces
{
    public interface ITeam : IParticipant
    {
        ReadOnlyCollection<ISportsman> Roster { get; }

        void SignContract(ISportsman sportsman);
    }
}