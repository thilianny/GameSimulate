using System;
using GameSimulate.Enums;

namespace GameSimulate.Interfaces
{
    public interface IPlayer : IParticipant
    {
        DateTime? Birthdate { get; }
    }
}