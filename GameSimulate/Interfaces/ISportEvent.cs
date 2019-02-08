using System;

namespace GameSimulate.Interfaces
{
    public interface ISportEvent
    {
        int Id { get; }
        DateTime Start { get; }
        
        void Simulate();
    }
}