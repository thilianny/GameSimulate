using System;

namespace GameSimulate.Interfaces
{
    public interface IGame
    {
        void Simulate();
        
        DateTime Date { get; }
    }
}