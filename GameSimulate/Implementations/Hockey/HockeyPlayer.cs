using System;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.Hockey
 {
     public class HockeyPlayer : Player
     {
         public HockeyPlayer(string name, int power, string country, string city, DateTime? birthdate) : base(name,
             power, country, city, birthdate)
         {
             Sport = Enums.Sport.Hockey;
         }
     }
 }