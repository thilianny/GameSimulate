using System;
using System.Collections.Generic;
using System.Linq;
using GameSimulate.Builders;
using GameSimulate.Common;
using GameSimulate.Enums;

namespace TestApp
{
    class Program
    {
        private static GameSimulator _simulator;

        private static void Main(string[] args)
        {
            _simulator = GameSimulator.Initialize();

           /* var kuch = _simulator
                .InitPlayerBuilder(Sport.Hockey)
                .SetName("Nikita Kucherov")
                .SetCountry("Russia")
                .SetPower(92)
                .SetBirthdate(DateTime.Today)
                .Build();

            var cristiano = _simulator
                .CreateSimplePlayer(Sport.Football, "Cristiano Ronaldo", 93);

            int x = 0;*/

            var kuch = _simulator
                .PlayerCreator
                .CreateSimple(Sport.Hockey, "Nikita Kucherov", 92);

            var cristiano = _simulator
                .PlayerCreator.InitializeBuilder(Sport.Football)
                .SetName("Cristiano Ronaldo")
                .SetCountry("Portugal")
                .SetPower(95)
                .Build();

            int x = 0;

        }

    }

}