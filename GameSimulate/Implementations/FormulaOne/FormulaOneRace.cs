using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GameSimulate.Interfaces;

namespace GameSimulate.Implementations.FormulaOne
{
    public class FormulaOneRace : IRace
    {
        public FormulaOneRace(DateTime? date, IEnumerable<IPlayer> participants)
        {
            Date = date;
            Participants = participants.ToList().AsReadOnly();
        }

        public void Simulate()
        {
            Console.WriteLine($"{Date:dd MMMM yyyy}: formula one race finished");
        }

        public DateTime? Date { get; }
        public ReadOnlyCollection<IPlayer> Participants { get; }
    }
}