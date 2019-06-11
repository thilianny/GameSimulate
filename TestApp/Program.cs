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
            var kuch = PlayerCreator.Create(Sport.Hockey, "Nikita Kucherov", 90);

            var reallive=new LiveFootballTeam(real);
            //reallive.Squad.Add()

        }

    }

   

}