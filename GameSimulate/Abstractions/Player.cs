using System;
using GameSimulate.Interfaces;

namespace GameSimulate.Abstractions
{
    public abstract class Player : Participant
    {
        protected Player(string name, int power, string country, string city, DateTime? birthdate) : base(name, power,
            country, city)
        {
            Pow = power;
            Birthdate = birthdate;
        }
        
        public ISport Sport { get; protected set; }

        public DateTime? Birthdate { get; }
        public override int Power => Pow;
    }
}