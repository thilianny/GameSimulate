namespace GameSimulate.Abstractions
{
    public abstract class Participant<TSport> where TSport : System.Enum
    {
        protected Participant(string name, int power, string country, string city)
        {
            Name = name;
            Pow = power;
            Country = country;
            City = city;
            
        }

        public TSport Sport { get; protected set; }
        public string Name { get; }
        public string Country { get; }
        public string City { get; }
        
        public abstract int Power { get; }
        internal int Pow;
    }
}