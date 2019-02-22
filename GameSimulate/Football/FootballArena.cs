using GameSimulate.Interfaces;

namespace GameSimulate.Football
{
    public class FootballArena : IArena<Footballer>
    {
        public string Name { get; }
        public string Country { get; }
        public int Capacity { get; }
        
        public FootballArena(string name, string country, int capacity)
        {
            Name = name;
            Country = country;
            Capacity = capacity;
        }
    }
}