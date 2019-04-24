using System;
using GameSimulate.Factories;
using GameSimulate.Interfaces;

namespace GameSimulate.Hockey
{
    public class HockeyGameFactory : GameFactory
    {
        public override IGame Create(DateTime date) => new HockeyGame(date);
    }
}