using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace GameSimulate.Abstractions
{
    public abstract class Team : Participant
    {
        protected Team(string name, int power, string country, string city) : base(name, power, country, city)
        {
            Pow = power;
            _roster = new List<Player>();
        }

        protected List<Player> _roster;
        public ReadOnlyCollection<Player> Roster => _roster.AsReadOnly();
        public override int Power => !Roster.Any() ? Pow : Roster.Sum(p => p.Power) / Roster.Count;
        

        public abstract void AttachRoster(IEnumerable<Player> roster);
        public abstract void Sign(Player player);

        public void Dissolve(Player player)
        {
            if (_roster.Contains(player))
                _roster.Remove(player);
        }
    }
}