using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GameSimulate.Interfaces
{
    public interface ISinglesEvent<T> : ISportEvent where T : ISportsman
    {
        ReadOnlyCollection<T> Participants { get; }

        // event registration
        void RegisterSingle(T participant);
        void RegisterList(IEnumerable<T> participants);
    }
}