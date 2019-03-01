using System;
using GameSimulate.Enums;
using GameSimulate.Interfaces;

namespace GameSimulate.Football
{
    public class FootballGame : ITeamGame<Football>, IConditionable<Conditions>
    {        
        public DateTime Date { get;}
        public EventStatus EventStatus { get; set; } = EventStatus.Announced;
        public Gender ParticipantsGender { get; set; } = Gender.Male;
        
        public IArena<Football> Location { get; }
        public int Attendance { get; }
        
        public ITeam<Football> Home { get; }
        public ITeam<Football> Away { get; }

        public Conditions Conditions { get; set; } = Conditions.Sunny;
        public int Temperature { get; set; } = 20;

        public FootballGame(DateTime date, FootballTeam home, FootballTeam away,
            FootballArena location, int attendance)
        {
            Date = date;
            Home = home;
            Away = away;
            Location = location;
            Attendance = attendance;
        }

        public void Simulate()
        {
            Console.WriteLine("FOOTBALL GAME PLAYED");
        }

    }
}