using System;

namespace GameSimulate.Abstractions
{
    public abstract class Player : Participant
    {
        protected Player(string name, int power, string country, string city, DateTime? birthdate) : base(name, country,
            city)
        {
            Power = power;
            Birthdate = birthdate;
        }

        public Team Team { get; internal set; } = null;
        public DateTime? Birthdate { get; }
    }
}