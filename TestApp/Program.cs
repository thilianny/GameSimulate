using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using GameSimulate.Biathlon;
using GameSimulate.Football;
using GameSimulate.Hockey;
using GameSimulate.Interfaces;

namespace TestApp
{
    [SuppressMessage("ReSharper", "PossibleLossOfFraction")]
    class Program
    {
        static void Main(string[] args)
        {

            var f = new Footballer(1, "Cristiano Ronaldo", 95);
            
            
            var h = new HockeyPlayer(8,"Alex Ovechkin", 95);

        }
    }
}