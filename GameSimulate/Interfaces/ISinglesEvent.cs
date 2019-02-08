using System;
using System.Collections.ObjectModel;

namespace GameSimulate.Interfaces
{
    public interface ISinglesEvent : ISportEvent
    {
        ReadOnlyCollection<ISportsman> Participants { get; }
        Weather Weather { get; set; }
        // event registration
        void RegisterParticipant(ISportsman sportsman);
    }
}