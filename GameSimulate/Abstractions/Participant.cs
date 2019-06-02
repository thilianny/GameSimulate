namespace GameSimulate.Abstractions
{
    public abstract class Participant
    {
        protected Participant(string name, string country)
        {
            Name = name;
            Country = country;
        }

        public string Name { get; }
        public int Power { get; protected set; } = 0;
        public string Country { get; }
    }
}