using System.Collections;
using System.Collections.Generic;
using GameSimulate.Enums;

namespace GameSimulate.Interfaces
{
    public interface IParticipant
    {
        string Name { get; }
        int Power { get; }
        string Country { get; }
    }
}