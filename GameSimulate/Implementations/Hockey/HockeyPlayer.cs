using System;
using GameSimulate.Interfaces;

namespace GameSimulate.Implementations.Hockey
 {
     public class HockeyPlayer : IPlayer
     {
         internal HockeyPlayer(string name, int power, string country, DateTime? birthdate)
         {
             Name = name;
             Power = power;
             Country = country;
             Birthdate = birthdate;
         }

         public string Name { get; }
         public int Power { get; }
         public string Country { get; }
         public DateTime? Birthdate { get; }
     }
 }