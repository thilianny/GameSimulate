using System;
using GameSimulate.Abstractions;
using GameSimulate.Enums;

namespace GameSimulate.Builders
{
    public abstract class PlayerBuilder : ParticipantBuilder<Player, Sport, PlayerBuilder>
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