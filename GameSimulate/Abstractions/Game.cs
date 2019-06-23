using System;

namespace GameSimulate.Abstractions
{
    public abstract class Game<TSport> 
        where TSport : Enum
    {
        protected Game(DateTime? date = null)
        {
            Date = date;
        }
        
        public TSport Sport { get; protected set; }

        public abstract void Simulate();
        
        public DateTime? Date { get; }
    }
}