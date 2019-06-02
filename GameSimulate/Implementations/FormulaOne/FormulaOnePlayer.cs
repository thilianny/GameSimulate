using System;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.FormulaOne
{
    public class FormulaOnePlayer : Player
    {
        public FormulaOnePlayer(string name, int power, string country, DateTime? birthdate) : base(name, power,
            country, birthdate)
        {
        }
    }
}