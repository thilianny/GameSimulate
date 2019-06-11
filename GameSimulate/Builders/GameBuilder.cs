using System;

namespace GameSimulate.Builders
{
    public class GameBuilder
    {
        protected DateTime? Date;

        internal GameBuilder()
        {
            
        }
        
        public GameBuilder SetDate(DateTime date)
        {
            Date = date;
            return this;
        }
    }
}