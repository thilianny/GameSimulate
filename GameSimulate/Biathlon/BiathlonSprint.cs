using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GameSimulate.Biathlon;
using GameSimulate.Football;
using GameSimulate.Interfaces;

namespace GameSimulate.Biathlon
{
    public class BiathlonSprint : IRace<Biathlete>
    {
        public int Id { get; set; }   
        public DateTime Start { get; }
        public Weather Weather { get; set; }
        
        private readonly List<Biathlete> _participants = new List<Biathlete>();
        public ReadOnlyCollection<Biathlete> Participants => _participants.AsReadOnly();
        
        public BiathlonSprint(DateTime start)
        {
            Start = start;
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