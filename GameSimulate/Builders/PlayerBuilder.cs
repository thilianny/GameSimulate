using System;
using GameSimulate.Interfaces;

namespace GameSimulate.Builders
{
    public abstract class PlayerBuilder
    {
        protected string Name;
        protected int Power;
        protected string Country;
        protected DateTime Birthdate;

        public PlayerBuilder SetName(string name)
        {
            Name = name;
            return this;
        }

        public PlayerBuilder SetPower(int power)
        {
            Power = power;
            return this;
        }

        public PlayerBuilder SetCountry(string country)
        {
            Country = country;
            return this;
        }

        public PlayerBuilder SetBirthdate(DateTime birthdate)
        {
            Birthdate = birthdate;
            return this;
        }

        public abstract IPlayer Build();
    }
}