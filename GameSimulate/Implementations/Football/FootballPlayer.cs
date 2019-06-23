using System;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.Football
{
    public class FootballPlayer : Player
    {
        public FootballPlayer(string name, int power, string country, string city, DateTime? birthdate) : base(name,
            power, country, city, birthdate)
        {
            Sport = Enums.Sport.Football;
        }
    }
}