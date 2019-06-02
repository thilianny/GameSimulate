using System;

namespace GameSimulate.Abstractions
{
    public abstract class Player : Participant
    {
        protected Player(string name, int power, string country, DateTime? birthdate) : base(name, country)
        {
            Power = power;
            Birthdate = birthdate;
        }
        
        public DateTime? Birthdate { get; }
    }
}