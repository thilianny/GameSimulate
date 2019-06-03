using System;
using System.Collections;
using System.Collections.Generic;
using GameSimulate.Abstractions;
using GameSimulate.Creators;
using GameSimulate.Enums;

namespace GameSimulate
{
    public class Session
    {
        public DateTime Opened { get; } = DateTime.Now;
        public DateTime? Closed { get; private set; }
        
        //public IList Players { get; private set; }
        public List<Player> Players { get; }

        public Guid Id { get; } = Guid.NewGuid();
        public Sport Sport { get; }

        public bool IsActive { get; private set; } = true;
        
        public PlayerCreator PlayerCreator { get; }

        internal Session(Sport sport)
        {
            Sport = sport;
            var sportName = Enum.GetName(typeof(Sport), Sport);
            //InitializePlayersList(sportName);
            PlayerCreator = new PlayerCreator(this);
            Players = new List<Player>();
        }
        

        /*private void InitializePlayersList(string sport)
        {
            
            var type = Type.GetType($"GameSimulate.Implementations.{sport}.{sport}Player");
            Players = (IList) Activator.CreateInstance(typeof(List<>).MakeGenericType(type));
            var x = 0;
        }*/

        internal void Close()
        {
            Closed = DateTime.Now;
            IsActive = false;
        }
    }
}