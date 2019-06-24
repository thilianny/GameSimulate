using GameSimulate.Creators;
using GameSimulate.Sports;

namespace TestApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            var cristiano = PlayerCreator.Create(Sport.Football, "Cristiano", 93);

            var real = TeamCreator.Create(Sport.Football, "Real Madrid FC", 92);
            var barca = TeamCreator.Create(Sport.Football, "FC Barcelona", 90);

            var clasico = GameCreator.TeamGame.Create(real, barca);

            clasico.Simulate();



        }

    }

   

}