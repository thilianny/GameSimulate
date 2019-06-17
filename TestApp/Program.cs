using GameSimulate;
using GameSimulate.Creators;
using GameSimulate.Enums;

namespace TestApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            var real = TeamCreator.Create(TeamSport.Football, "Real Madrid FC", 95);
            var cristiano = PlayerCreator.Create(Sport.Football, "Cristiano Ronaldo", 93);
            real.Sign(cristiano);
            
            
            var barca = TeamCreator.Create(TeamSport.Football, "FC Barcelona", 93);
            var messi = PlayerCreator.Create(Sport.Football, "Lionel Messi", 90);
            //barca.Sign(messi);

            var clasico = GameCreator.TeamGame.Create(real, barca);
            
            Simulator.Execute(clasico);

            int x = 0;



        }

    }

   

}