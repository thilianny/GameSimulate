using System;

namespace GameSimulate.Abstractions
{
    public abstract class GameBuilder<TGame, TBuilder> : Builder 
        where TGame : Game
        where TBuilder : GameBuilder<TGame, TBuilder>
    {
        protected abstract TBuilder BuilderInstance { get; }
        
        protected DateTime? Date;
        
        public TBuilder SetDate(DateTime? date)
        {
            Date = date;
            return BuilderInstance;
        }

        public TBuilder SetArena()
        {
            return BuilderInstance;
        }
        
        //public abstract TGame Build(string test);
    }
}