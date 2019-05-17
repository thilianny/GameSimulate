using System;
using System.Collections.Generic;
using GameSimulate.Builders;
using GameSimulate.Enums;
using GameSimulate.Factories;
using GameSimulate.Interfaces;

namespace GameSimulate
{
    public class GameSimulator
    {
        private readonly Dictionary<Sport, GameFactory> _gameFactories;

        private GameSimulator()
        {
            _gameFactories=new Dictionary<Sport, GameFactory>();
            
            PlayerCreator = new PlayerCreator();
            TeamCreator = new TeamCreator();

            foreach (Sport sport in Enum.GetValues(typeof(Sport)))
            {
                var sportName = Enum.GetName(typeof(Sport), sport);
                _gameFactories.Add(sport, InitializeGameFactory(sportName));
            }
        }

        private static GameFactory InitializeGameFactory(string sportName)
        {          
            return (GameFactory) Activator.CreateInstance(
                Type.GetType($"GameSimulate.{sportName}.{sportName}GameFactory"));
        }

        public static GameSimulator Initialize() => new GameSimulator();

        public IGame CreateGame(Sport sport, DateTime date)
        {
            return Enum.IsDefined(typeof(Sport), sport) && _gameFactories.ContainsKey(sport)
                ? _gameFactories[sport].Create(date)
                : null;
        }

        public PlayerCreator PlayerCreator { get; }
        public TeamCreator TeamCreator { get; }
    }
}