using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GameSimulate.Biathlon;
using GameSimulate.Football;
using GameSimulate.Interfaces;

namespace GameSimulate.Biathlon
{
    public class BiathlonSprint : IRace
    {
        public int Id { get; set; }
        
        public DateTime Start { get; set; }
        
        private readonly List<ISportsman> _participants = new List<ISportsman>();
        public ReadOnlyCollection<ISportsman> Participants => _participants.AsReadOnly();

   
        
        public Weather Weather { get; set; }

        public void RegisterParticipant(ISportsman sportsman)
        {
            _participants.Add(sportsman);
        }
        
        public void Simulate()
        {
            foreach (var participant in _participants)
            {
                participant.Move();
            }

            foreach (var participant in _participants)
            {
                //((Biathlete)participant).ProneShot();
            }
            
            foreach (var participant in _participants)
            {
                participant.Move();
            }
            
            foreach (var participant in _participants)
            {
                //((Biathlete)participant).StandingShot();
            }
            
            foreach (var participant in _participants)
            {
                participant.Move();
            }
            
            Console.WriteLine("BIATHLON SPRINT FINISHED");
        }
    }
}