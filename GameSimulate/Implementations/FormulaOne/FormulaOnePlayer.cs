using System;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.FormulaOne
{
    public class FormulaOnePlayer : Player
    {
        public FormulaOnePlayer(string name, int power, string country, string city, DateTime? birthdate) : base(name,
            power, country, city, birthdate)
        {
            Sport = Enums.Sport.FormulaOne;
        }
    }
}