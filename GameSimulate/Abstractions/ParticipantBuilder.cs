namespace GameSimulate.Abstractions
{
    public abstract class ParticipantBuilder<TParticipant, TBuilder> : Builder
        where TParticipant : Participant
        where TBuilder : ParticipantBuilder<TParticipant, TBuilder>
    {
        protected string Country;
        protected string City;

        protected abstract TBuilder BuilderInstance { get; }

        public TBuilder SetCountry(string country)
        {
            Country = country;
            return BuilderInstance;
        }

        public TBuilder SetCity(string city)
        {
            City = city;
            return BuilderInstance;
        }

        public abstract TParticipant Build(string name, int power = 0);
    }
}