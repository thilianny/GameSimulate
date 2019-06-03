namespace GameSimulate.Abstractions
{
    public abstract class Participant
    {
        protected Participant(string name, string country, string city)
        {
            Name = name;
            Country = country;
            City = city;
        }

        public string Name { get; }
        public int Power { get; protected set; } = 0;
        public string Country { get; }
        public string City { get; }
    }
}