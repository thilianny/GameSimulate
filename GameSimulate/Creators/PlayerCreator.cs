using System;
using System.Reflection;
using GameSimulate.Abstractions;
using GameSimulate.Builders;
using GameSimulate.Enums;
using GameSimulate.Sessions;

namespace GameSimulate.Creators
{
    public class PlayerCreator
    {
        private readonly Session _session;
        private readonly string _sportName;

        internal PlayerCreator(Session session)
        {
            _session = session;
            _sportName = Enum.GetName(typeof(Sport), _session.Sport);

        }
        
        public Player Create(string name, int power)
        {
            var builder = (PlayerBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{_sportName}.{_sportName}PlayerBuilder"), true);

            var player = builder.Build(name, power);
            _session.Players.Add(player);
            return player;
        }

        public PlayerBuilder InitializeBuilder()
        {
            var builder = (PlayerBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{_sportName}.{_sportName}PlayerBuilder"), true);
            builder.Session = _session;
            return builder;
        }
    }
}