using System;
using System.ComponentModel;
using GameSimulate.Creators;
using GameSimulate.Enums;
using GameSimulate.Interfaces;

namespace GameSimulate
{
    public class Session
    {
        private readonly ISport _sport;
        public Guid Id { get; }
        
        public string Sport => _sport.GetType().Name;
        public DateTime? Opened { get; }

        private Session(Sport sport)
        {
            
            var sportName = Enum.GetName(typeof(Sport), sport);
            var sportType = (ISport) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{sportName}.{sportName}"), true);

            Opened = DateTime.Now;
            _sport = sportType;
            Id = Guid.NewGuid();

            PlayerCreator = new PlayerCreator(_sport);
            TeamCreator = new TeamCreator(_sport);
        }

        public PlayerCreator PlayerCreator { get; }
        public TeamCreator TeamCreator { get; }

        public static Session Open(Sport sport) => new Session(sport);
    }
}