using System;

namespace GameSimulate.Interfaces
{
    public interface ISportEvent
    {
        void AddParticipant(int id, string title, int power);
        void Simulate();
    }
}