using System;
using GameSimulate.Creators;
using GameSimulate.Enums;

namespace TestApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            /*var cristiano = PlayerCreator.CreateSimple(Sport.Team.Football, "Cristiano Ronaldo", 92);

            var kuch = PlayerCreator
                .InitializeBuilder(Sport.Team.Hockey)
                .SetBirthdate(DateTime.Now)
                .SetCountry("Russia")
                .Build("Nikita Kucherov", 92);
            
            var home = TeamCreator.CreateSimple(Sport.Team.Hockey, "Tampa Bay Lightning", 92);
            var away = TeamCreator.CreateSimple(Sport.Team.Hockey, "St. Louis Blues", 93);

            var hamilton = PlayerCreator.CreateSimple(Sport.Team.Hockey, "Lewis Hamilton", 90);

            var vettel = PlayerCreator
                .InitializeBuilder(Sport.Team.Hockey)
                .SetBirthdate(DateTime.Now)
                .SetCountry("Germany")
                .Build("Sebastian Vettel", 90);

            var x = 0;*/
            var p = PlayerCreator.CreateSimple(Sport.Hockey, "Pesduke", 81);
            var y = 0;

        }

    }

}