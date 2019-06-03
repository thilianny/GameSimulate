using GameSimulate.Abstractions;
using GameSimulate.Builders;

namespace GameSimulate.Implementations.FormulaOne
{
    public class FormulaOnePlayerBuilder : PlayerBuilder
    {
        internal FormulaOnePlayerBuilder()
        {
            
        }

        public override Player Build(string name, int power)
        {
            var player = new FormulaOnePlayer(name, power, Country, City, Birthdate);
            Session.Players.Add(player);
            return player;
        }
    }
}