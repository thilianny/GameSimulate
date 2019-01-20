using System;

namespace GameSimulate.Classes
{
    public class Biathlete
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Power { get; set; }

        public Biathlete(int id, string title, int power)
        {
            Id = id;
            Title = title;
            Power = power;
        }
        
        public void Move()
        {
            Console.WriteLine($"biathlete {Title} moves!");
        }

        public void Shoot()
        {
            Console.WriteLine($"biathlete {Title} shoots!");
        }
    }
}