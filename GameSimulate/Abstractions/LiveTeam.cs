using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace GameSimulate.Abstractions
{
    public abstract class LiveTeam
    {
        private Team _team;

        public LiveTeam(Team team)
        {
            _team = team;
            _power = _team.Power;
            _squad = new List<LivePlayer>();
        }

        public string Name => _team.Name;
        public string Country => _team.Country;

        protected List<LivePlayer> _squad;
        public ReadOnlyCollection<LivePlayer> Squad => _squad.AsReadOnly();

        private int _power;
        public int Power
        {
            get
            {
                var activeSquad = _squad.Where(p => p.IsActive).ToList();
                if (!activeSquad.Any()) return _power;
                return activeSquad.Sum(p => p.Power) / activeSquad.Count;
            }
        }
    }
}