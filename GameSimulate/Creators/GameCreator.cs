using System;
using GameSimulate.Abstractions;
using GameSimulate.Builders;
using GameSimulate.Enums;

namespace GameSimulate.Creators
{
    public static class GameCreator
    {
        public static TeamGameCreator TeamGame => new TeamGameCreator();
    }
}