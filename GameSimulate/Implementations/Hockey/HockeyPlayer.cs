using System;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.Hockey
 {
     public class HockeyPlayer : Player
     {
         public HockeyPlayer(string name, int power, string country, DateTime? birthdate) : base(name, power, country,
             birthdate)
         {
         }
     }
 }