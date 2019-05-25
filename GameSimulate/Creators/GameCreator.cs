using System;
using GameSimulate.Builders;
using GameSimulate.Enums;
using GameSimulate.Interfaces;

namespace GameSimulate.Creators
{
    public static class GameCreator
    {
        public static GameBuilder InitializeBuilder() => new GameBuilder();
    }
}