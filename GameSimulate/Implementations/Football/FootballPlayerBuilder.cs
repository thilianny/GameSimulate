using GameSimulate.Abstractions;
using GameSimulate.Builders;

namespace GameSimulate.Implementations.Football
{
    public class FootballPlayerBuilder : PlayerBuilder
    {
        internal FootballPlayerBuilder()
        {
            
        }
        
        public override Player Build(string name, int power)
        {
            var player = new FootballPlayer(name, power, Country, City, Birthdate);
            Session?.Players.Add(player);
            return player;
        }
    }
}