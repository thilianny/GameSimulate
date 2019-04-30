using System;
using GameSimulate.Interfaces;

namespace GameSimulate.Builders
{
    public abstract class PlayerBuilder
    {
        protected string _name;
        protected int _power;
        protected string _country;
        protected DateTime _birthdate;

        public PlayerBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public PlayerBuilder SetPower(int power)
        {
            _power = power;
            return this;
        }

        public PlayerBuilder SetCountry(string country)
        {
            _country = country;
            return this;
        }

        public PlayerBuilder SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
            return this;
        }

        public abstract IPlayer Build();
    }
}