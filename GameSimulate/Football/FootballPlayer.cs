using System;
using System.Collections.Generic;
using GameSimulate.Enums;
using GameSimulate.Interfaces;

namespace GameSimulate.Football
{
    public class FootballPlayer : IPlayer
    {
        public FootballPlayer(string name, int power, string country, DateTime birthdate)
        {
            Name = name;
            Power = power;
            Country = country;
            Birthdate = birthdate;
        }

        public string Name { get; }
        public int Power { get; }
        public string Country { get; }
        public DateTime Birthdate { get; }
    }
}