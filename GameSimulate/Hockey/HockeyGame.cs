using System;
using GameSimulate.Interfaces;

namespace GameSimulate.Hockey
{
    public class HockeyGame : ITeamGame
    {
        public IParticipant Home { get; set; }
        public IParticipant Away { get; set; }
        
        public void AddParticipant(int id, string title, int power)
        {
            if (Home == null)
            {
                Home = new HockeyTeam(id, title, power);
            }
            else if (Away == null)
            {
                Away = new HockeyTeam(id, title, power);
            }
            else
            {
                throw new Exception("Hockey game need 2 teams");
            }
        }
        
        public void Simulate()
        {
            Home.Move();
            Away.Move();
            Console.WriteLine("HOCKEY GAME PLAYED");
        }
    }
}