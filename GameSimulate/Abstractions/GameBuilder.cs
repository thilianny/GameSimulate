using System;

namespace GameSimulate.Abstractions
{
    public abstract class GameBuilder<TGame, TSport, TBuilder> : Builder 
        where TGame : Game<TSport>
        where TSport : Enum
        where TBuilder : GameBuilder<TGame, TSport, TBuilder>
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