using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.WebSockets;
using System.Threading.Tasks.Sources;
using GameSimulate;
using GameSimulate.Abstractions;
using GameSimulate.Creators;
using GameSimulate.Enums;
using GameSimulate.Exceptions;
using GameSimulate.Implementations;
using GameSimulate.Implementations.Football;
using GameSimulate.Interfaces;

namespace TestApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            /*var tampa = TeamCreator.Create(TeamSport.Hockey, "Tampa Bay Lightning", 93);
            var boston = TeamCreator.Create(TeamSport.Hockey, "Boston Bruins", 93);

            var game = GameCreator.CreateTeamGame(tampa, boston);
            
            Simulator.Execute(game);*/

            var f = Simulator.OpenSession(Sport.Football);
            var cristiano = f.PlayerCreator.Create("Cristiano Ronaldo", 93);

            var messi = f.PlayerCreator
                .InitializeBuilder()
                .SetCountry("Argentina")
                .SetCity("Buenos Aires")
                .Build("Lionel Messi", 93);
            
            int s = 0;

        }

    }

   

}