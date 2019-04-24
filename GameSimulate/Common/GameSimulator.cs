using System;
using System.Collections.Generic;
using System.Xml;
using GameSimulate.Enums;
using GameSimulate.Factories;
using GameSimulate.Interfaces;

namespace GameSimulate.Common
{
    public class GameSimulator
    {
        private readonly Dictionary<Sport, GameFactory> _gameFactories;
        private readonly Dictionary<Sport, PlayerFactory> _playerFactories;

        private GameSimulator()
        {
            _gameFactories=new Dictionary<Sport, GameFactory>();
            _playerFactories=new Dictionary<Sport, PlayerFactory>();

            foreach (Sport sport in Enum.GetValues(typeof(Sport)))
            {
                var sportName = Enum.GetName(typeof(Sport), sport);
                _gameFactories.Add(sport, InitializeGameFactory(sportName));
                _playerFactories.Add(sport, InitializePlayerFactory(sportName));
            }
        }

        private static GameFactory InitializeGameFactory(string sportName)
        {          
            return (GameFactory) Activator.CreateInstance(
                Type.GetType($"GameSimulate.{sportName}.{sportName}GameFactory"));
        }
        
        private static PlayerFactory InitializePlayerFactory(string sportName)
        {
            return (PlayerFactory) Activator.CreateInstance(
                Type.GetType($"GameSimulate.{sportName}.{sportName}PlayerFactory"));
        }

        public static GameSimulator Initialize() => new GameSimulator();

        public IGame CreateGame(Sport sport, DateTime date)
        {
            return Enum.IsDefined(typeof(Sport), sport) && _gameFactories.ContainsKey(sport)
                ? _gameFactories[sport].Create(date)
                : null;
        }
        
        public IPlayerBuilder InitializePlayer(Sport sport)
        {
            return Enum.IsDefined(typeof(Sport), sport) && _playerFactories.ContainsKey(sport)
                ? _playerFactories[sport].Create()
                : null;
        }
    }
}