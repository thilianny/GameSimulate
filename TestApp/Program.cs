using System;
using System.Collections.Generic;
using System.Linq;
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

            var kuch = _simulator
                .InitializePlayer(Sport.Hockey)
                .SetName("Nikita Kucherov")
                .SetCountry("Russia")
                .SetPower(92)
                .SetBirthdate(DateTime.Today)
                .Create();

            int x = 0;
        }

    }
}