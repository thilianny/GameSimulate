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
        private readonly List<IParticipant> _participants = new List<IParticipant>();
        public ReadOnlyCollection<IParticipant> Participants => _participants.AsReadOnly();

        public void AddParticipant(int id, string title, int power)
        {
            _participants.Add(new Biathlete(id, title, power));
        }
        
        public void Simulate()
        {
            foreach (var participant in Participants)
            {
                participant.Move();
            }

            foreach (var participant in Participants)
            {
                ((Biathlete)participant).ProneShot();
            }
            
            foreach (var participant in Participants)
            {
                participant.Move();
            }
            
            foreach (var participant in Participants)
            {
                ((Biathlete)participant).StandingShot();
            }
            
            foreach (var participant in Participants)
            {
                participant.Move();
            }
            
            Console.WriteLine("BIATHLON SPRINT FINISHED");
        }
    }
}