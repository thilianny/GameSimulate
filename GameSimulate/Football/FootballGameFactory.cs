using System;
using GameSimulate.Factories;
using GameSimulate.Interfaces;

namespace GameSimulate.Football
{
    public class FootballGameFactory : GameFactory
    {
        public override IGame Create(DateTime date) => new FootballGame(date);
    }
}