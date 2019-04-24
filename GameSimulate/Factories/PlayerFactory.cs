using System.Collections.Generic;
using GameSimulate.Enums;
using GameSimulate.Interfaces;

namespace GameSimulate.Factories
{
    public abstract class PlayerFactory
    {
        public abstract IPlayerBuilder Create();
    }
}