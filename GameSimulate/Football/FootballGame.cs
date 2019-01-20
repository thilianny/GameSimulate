using System;
using System.Collections.Generic;
using GameSimulate.Interfaces;

namespace GameSimulate.Classes
{
    public class FootballGame : ITeamGame
    {
        public IParticipant Home { get; set; }
        public IParticipant Away { get; set; }

        public void AddParticipant(int id, string title, int power)
        {
            if (Home == null)
            {
                Home = new FootballTeam(id, title, power);
            }
            else if (Away == null)
            {
                Away = new FootballTeam(id, title, power);
            }
            else
            {
                throw new Exception("Football game need 2 teams");
            }
            
        }
        
        public void Simulate()
        {
            Home.Move();
            Away.Move();
            Console.WriteLine("FOOTBALL GAME PLAYED");
        }
    }
}