using GameSimulate.Abstractions;
using GameSimulate.Builders;

namespace GameSimulate.Implementations.FormulaOne
{
    public class FormulaOnePlayerBuilder : PlayerBuilder
    {
        internal FormulaOnePlayerBuilder()
        {
            
        }
        public override Player Build(string name, int power) => new FormulaOnePlayer(name, power, Country, Birthdate);
    }
}