using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.WebSockets;
using System.Threading.Tasks.Sources;
using GameSimulate;
using GameSimulate.Abstractions;
using GameSimulate.Builders;
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
            var s = Simulator.OpenTeamSession(TeamSport.Football);

            var t = s.TeamCreator
                .InitializeBuilder()
                .SetCountry("Spain")
                .Test()
                .SetCity("Barcelona")
                .Build("FC Barcelona", 93);

            var p = s.PlayerCreator
                .InitializeBuilder()
                .SetCountry("Portugal")
                .SetBirthdate(null)
                .SetCity("Lisbon")
                .Build("Cristiano Ronaldo", 92);

            var f = Simulator.OpenRacingSession(RacingSport.FormulaOne);

            var h = f.PlayerCreator
                .InitializeBuilder()
                .SetCountry("United Kingdom")
                .SetBirthdate(null)
                .SetCity("London")
                .Build("Lewis Hamilton", 90);

            var ff = 0;
        }

    }

   

}