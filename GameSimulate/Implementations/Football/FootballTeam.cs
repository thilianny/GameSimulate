using System.Collections.Generic;
using System.Linq;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.Football
{
    public class FootballTeam : Team
    {
 
         internal FootballTeam(string name, int power, string country, string city) : base(name, power, country, city)
         {
         }
 
         public override void AttachRoster(IEnumerable<Player> roster)
         {
             _roster.AddRange(roster.Where(p => p is FootballPlayer));
         }
 
         public override void Sign(Player player)
         {
             if (player is FootballPlayer)
                 _roster.Add(player);
         }
     }
 }