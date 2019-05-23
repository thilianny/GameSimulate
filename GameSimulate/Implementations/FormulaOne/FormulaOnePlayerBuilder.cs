using GameSimulate.Builders;
using GameSimulate.Interfaces;

namespace GameSimulate.Implementations.FormulaOne
{
    public class FormulaOnePlayerBuilder : PlayerBuilder
    {
        internal FormulaOnePlayerBuilder()
        {
            
        }
        public override IPlayer Build(string name, int power) => new FormulaOnePlayer(name, power, Country, Birthdate);
    }
}