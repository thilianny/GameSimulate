using System;
using GameSimulate.Interfaces;

namespace GameSimulate.Builders
{
    public abstract class PlayerBuilder
    {
        protected string Country;
        protected DateTime? Birthdate;

        public PlayerBuilder SetCountry(string country)
        {
            Country = country;
            return this;
        }

        public PlayerBuilder SetBirthdate(DateTime? birthdate)
        {
            Birthdate = birthdate;
            return this;
        }

        public abstract IPlayer Build(string name, int power);
    }
}