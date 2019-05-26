using System;
using GameSimulate.Builders;
using GameSimulate.Enums;
using GameSimulate.Interfaces;

namespace GameSimulate.Creators
{
    public class GameCreator
    {
        internal GameCreator()
        {
            
        }
        
        public static GameBuilder InitializeBuilder() => new GameBuilder();
    }
}