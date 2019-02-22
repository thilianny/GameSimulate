using System;
using GameSimulate.Enums;

namespace GameSimulate.Interfaces
{
    public interface ISportEvent<T> where T : ISportsman
    {
        DateTime Date { get; }
        EventStatus EventStatus { get; set; }
        Gender ParticipantsGender { get; }
        
        IArena<T> Location { get; }
        int Attendance { get; }
        
        void Simulate();
    }
}