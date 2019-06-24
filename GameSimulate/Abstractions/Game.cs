using System;
using GameSimulate.Enums;

namespace GameSimulate.Abstractions
{
    public abstract class Game
    {
        protected Game(DateTime? date = null)
        {
            Date = date;
            Status = EventStatus.Announced;
        }
        
        public EventStatus Status { get; protected set; }

        public abstract void Simulate();
        
        public DateTime? Date { get; }
    }
}