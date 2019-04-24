using System;
using GameSimulate.Interfaces;

namespace GameSimulate.Builders
{
    public abstract class PlayerBuilder : IPlayerBuilder
    {
        protected string _name;
        protected int _power;
        protected string _country;
        protected DateTime _birthdate;

        public IPlayerBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public IPlayerBuilder SetPower(int power)
        {
            _power = power;
            return this;
        }

        public IPlayerBuilder SetCountry(string country)
        {
            _country = country;
            return this;
        }

        public IPlayerBuilder SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
            return this;
        }

        public abstract IPlayer Create();
    }
}