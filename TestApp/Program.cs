using System;
using GameSimulate.Biathlon;
using GameSimulate.Hockey;
using GameSimulate.Interfaces;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {          
            ISportEvent game = new BiathlonSprint();
            
            game.AddParticipant(1, "Dorothea Wierer", 94);
            game.AddParticipant(2, "Franziska Preuss", 80);
           
            game.Simulate();

            Console.ReadLine();
        }
    }
}