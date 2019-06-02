using System;
using GameSimulate.Abstractions;

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

        public abstract Player Build(string name, int power);
    }
}