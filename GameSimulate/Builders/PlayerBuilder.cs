using System;
using GameSimulate.Abstractions;
using GameSimulate.Sessions;

namespace GameSimulate.Builders
{
    public abstract class PlayerBuilder : ParticipantBuilder<Player, PlayerBuilder>
    {
        protected DateTime? Birthdate;

        public PlayerBuilder SetBirthdate(DateTime? birthdate)
        {
            Birthdate = birthdate;
            return this;
        }
        
        protected override PlayerBuilder BuilderInstance => this;
    }
}