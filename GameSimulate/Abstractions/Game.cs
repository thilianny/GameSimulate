using System;

namespace GameSimulate.Abstractions
{
    public abstract class Game
    {
        protected Game(DateTime? date = null)
        {
            Date = date;
        }

        internal abstract void Simulate();
        
        public DateTime? Date { get; }
    }
}