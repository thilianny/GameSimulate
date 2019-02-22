using GameSimulate.Interfaces;

namespace GameSimulate.Biathlon
{
    public class BiathlonTrack : IArena<Biathlete>
    {
        public string Name { get; }
        public string Country { get; }
        public int Capacity { get; }
        
        public BiathlonTrack(string name, string country, int capacity)
        {
            Name = name;
            Country = country;
            Capacity = capacity;
        }
    }
}