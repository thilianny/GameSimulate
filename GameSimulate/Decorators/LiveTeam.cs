using System.Collections.ObjectModel;
using GameSimulate.Interfaces;

namespace GameSimulate.Decorators
{
    public abstract class LiveTeam : ITeam
    {
        public string Name { get; }
        public int Power { get; }
        public string Country { get; }
        public string City { get; }
        public ReadOnlyCollection<IPlayer> Roster { get; }

        protected ITeam _team;

        public LiveTeam(ITeam team)
        {
            _team = team;
        }
    }
}