using System;
using System.Collections.Generic;
using GameSimulate.Biathlon;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var sprint=new BiathlonSprint(DateTime.Now);
            sprint.RegisterList(new List<Biathlete>
            {
                new Biathlete(1, "Dorothea Wierer", 95),
                new Biathlete(2, "Lisa Vittozzi", 92),
            });
            sprint.RegisterSingle(new Biathlete(3,"Laura Dahlmeier",90));

            foreach (var b in sprint.Participants)
            {
                Console.WriteLine($"{b.Name} {b.Power}");
            }
            
            

        }
    }
}