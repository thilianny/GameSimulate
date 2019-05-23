using System;
using GameSimulate.Builders;
using GameSimulate.Enums;
using GameSimulate.Interfaces;

namespace GameSimulate.Creators
{
    public static class GameCreator
    {  
        public static GameBuilder InitializeBuilder(GameType gameType)
        {
            switch (gameType)
            {
                case GameType.Team:
                    return new TeamGameBuilder();
                case GameType.Singles:
                    return new SinglesGameBuilder();
                case GameType.Racing:
                    return new RaceBuilder();
                default:
                    throw new ArgumentOutOfRangeException(nameof(gameType), gameType, null);
            }
        }
    }
}