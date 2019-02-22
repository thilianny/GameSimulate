using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GameSimulate.Biathlon;
using GameSimulate.Enums;
using GameSimulate.Football;
using GameSimulate.Interfaces;

namespace GameSimulate.Biathlon
{
    public class BiathlonSprint : IRace<Biathlete>, IConditionable<Conditions>
    {  
        public DateTime Date { get; }
        public EventStatus EventStatus { get; set; } = EventStatus.Announced;
        public Gender ParticipantsGender { get; }
        public IArena<Biathlete> Location { get; }
        public int Attendance { get; }
        public Conditions Conditions { get; set; } = Conditions.Sunny;
        public int Temperature { get; set; } = -5;
        
        private readonly List<Biathlete> _participants = new List<Biathlete>();
        public ReadOnlyCollection<Biathlete> Participants => _participants.AsReadOnly();
        
        public BiathlonSprint(DateTime date, Gender participantsGender, IArena<Biathlete> location, int attendance)
        {
            Date = date;
            ParticipantsGender = participantsGender;
            Location = location;
            Attendance = attendance;
        }
        
        public void RegisterSingle(Biathlete biathlete)
        {
            _participants.Add(biathlete);
        }

        public void RegisterList(IEnumerable<Biathlete> biathletes)
        {
            _participants.AddRange(biathletes);
        }




        public void Simulate()
        {
            Console.WriteLine("BIATHLON SPRINT FINISHED");
        }

    }
}