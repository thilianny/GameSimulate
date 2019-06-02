using System.Collections.Generic;
using System.Linq;
using GameSimulate.Abstractions;
using GameSimulate.Interfaces;

namespace GameSimulate.Builders
{
    public abstract class TeamBuilder
    {
        protected string Name;
        protected string Country;
        protected string City;

        public TeamBuilder SetName(string name)
        {
            Name = name;
            return this;
        }

        public TeamBuilder SetCountry(string country)
        {
            Country = country;
            return this;
        }

        public TeamBuilder SetCity(string city)
        {
            City = city;
            return this;
        }

        public abstract Team Build(int power);
        public abstract Team Build(IEnumerable<Player> roster);
    }
}
