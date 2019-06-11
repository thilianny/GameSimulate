using GameSimulate.Abstractions;
using GameSimulate.Builders;

namespace GameSimulate.Implementations.FormulaOne
{
    public class FormulaOnePlayerBuilder : PlayerBuilder
    {
        internal FormulaOnePlayerBuilder()
        {
            
        }

        public override Player Build(string name, int power = 0) =>
            new FormulaOnePlayer(name, power, Country, City, Birthdate);
    }
}