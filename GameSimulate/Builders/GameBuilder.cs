using System;
using System.Collections.Generic;
using GameSimulate.Implementations.Football;
using GameSimulate.Implementations.Hockey;
using GameSimulate.Interfaces;

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