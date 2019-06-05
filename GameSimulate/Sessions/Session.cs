using System;
using System.Collections.Generic;
using GameSimulate.Abstractions;
using GameSimulate.Creators;
using GameSimulate.Enums;

namespace GameSimulate.Sessions
{
    public abstract class Session
    {
        public DateTime Opened { get; } = DateTime.Now;
        public DateTime? Closed { get; private set; }
        
        //public IList Players { get; private set; }
        public List<Player> Players { get; }

        public Guid Id { get; } = Guid.NewGuid();
        public Sport Sport { get; internal set; }

        public bool IsActive { get; private set; } = true;
        
        public PlayerCreator PlayerCreator { get; protected set; }
        

        protected Session()
        {
            var sportName = Enum.GetName(typeof(Sport), Sport);
            //InitializePlayersList(sportName);
            
            Players = new List<Player>();
        }

        internal abstract void InitializeCreators();
        

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