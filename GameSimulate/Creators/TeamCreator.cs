using System;
using System.Collections.Generic;
using GameSimulate.Abstractions;
using GameSimulate.Builders;
using GameSimulate.Enums;
using GameSimulate.Interfaces;
using GameSimulate.Sessions;

namespace GameSimulate.Creators
{
    public class TeamCreator
    {
        private readonly TeamSession _session;
        private readonly string _sportName;
        
        internal TeamCreator(TeamSession session)
        {
            _session = session;
            _sportName = Enum.GetName(typeof(Sport), _session.Sport);

        }
        
       /* public Team Create(string name, int power)
        {
            var builder = (TeamBuilder) Activator.CreateInstance(
                    Type.GetType($"GameSimulate.Implementations.{_sportName}.{_sportName}TeamBuilder"), true);

            var team = builder.Build(name, power);
            _session.Teams.Add(team);
            return team;
        }*/

        public TeamBuilder InitializeBuilder()
        {
            var builder = (TeamBuilder) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Implementations.{_sportName}.{_sportName}TeamBuilder"), true);
            //builder.Session = _session;
            return builder;
        }
    }
}