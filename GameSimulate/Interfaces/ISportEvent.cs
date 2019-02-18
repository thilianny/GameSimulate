using System;

namespace GameSimulate.Interfaces
{
    public interface ISportEvent
    {
        DateTime Start { get; }
        
        void Simulate();
    }
}