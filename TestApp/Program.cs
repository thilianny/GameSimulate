using GameSimulate.Abstractions;
using GameSimulate.Creators;
using GameSimulate.Enums;
using GameSimulate.Implementations.Football;
using GameSimulate.Implementations.Hockey;

namespace TestApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            var real = TeamCreator.Create(TeamSport.Football, "Real Madrid FC", 95);
            var barca = TeamCreator.Create(TeamSport.Football, "FC Barcelona", 93);

            var clasico = GameCreator.TeamGame.Create(real, barca);

            int x = 0;



        }

    }

   

}