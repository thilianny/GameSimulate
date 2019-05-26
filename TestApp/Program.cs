using System;
using System.ComponentModel;
using System.Net.WebSockets;
using System.Threading.Tasks.Sources;
using GameSimulate;
using GameSimulate.Creators;
using GameSimulate.Enums;
using GameSimulate.Implementations;
using GameSimulate.Implementations.Football;
using GameSimulate.Interfaces;

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

            var footballSession = Session.Open(Sport.Football);
            Console.WriteLine(footballSession.Id);
            var hockeySession = Session.Open(Sport.Hockey);
            Console.WriteLine(hockeySession.Id);
            var cristiano = footballSession.PlayerCreator.CreateSimple("Cristiano Ronaldo", 92);

            var tampa = hockeySession.TeamCreator.CreateSimple(("Tampa Bay Lightning"), 93);

            int x = 0;



        }

    }

}