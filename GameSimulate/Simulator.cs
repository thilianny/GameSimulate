using System;
using GameSimulate.Interfaces;

namespace GameSimulate
{
    public static class Simulator
    {
        public static void Execute(IGame game)
        {
            game?.Simulate();
        }
    }
}