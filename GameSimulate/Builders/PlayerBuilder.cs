using System;
using GameSimulate.Abstractions;

namespace GameSimulate.Builders
{
    public abstract class PlayerBuilder
    {
        protected string Country;
        protected string City;
        protected DateTime? Birthdate;

        internal Session Session;

        internal PlayerBuilder()
        {
            
        }

        public PlayerBuilder SetCountry(string country)
        {
            Country = country;
            return this;
        }
        
        public PlayerBuilder SetCity(string city)
        {
            City = city;
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