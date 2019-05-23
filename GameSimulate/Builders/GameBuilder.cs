using System;

namespace GameSimulate.Builders
{
    public abstract class GameBuilder
    {
        protected DateTime? Date;
        
        public GameBuilder SetDate(DateTime date)
        {
            Date = date;
            return this;
        }
    }
}