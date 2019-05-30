using System.Collections;
using System.Collections.Generic;

namespace GameSimulate.Interfaces
{
    public interface IRoster
    {
        IEnumerable<IParticipant> Participants { get; }
    }
}