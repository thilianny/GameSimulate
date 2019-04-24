using System;
using GameSimulate.Interfaces;

namespace GameSimulate.Factories
{
    public abstract class GameFactory
    {
        public abstract IGame Create(DateTime date);
    }
}