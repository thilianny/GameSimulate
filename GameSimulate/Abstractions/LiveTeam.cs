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
            _power = _team.Pow;
           // _lineup = new List<LivePlayer>();
        }

        public string Name => _team.Name;
        public string Country => _team.Country;

        protected IEnumerable<LivePlayer> _lineup;
        public ReadOnlyCollection<LivePlayer> Lineup => _lineup.ToList().AsReadOnly();

        internal int _power;
        public int Power
        {
            get
            {
                var activeLineup = _lineup.Where(p => p.IsActive).ToList();
                if (!activeLineup.Any()) return _power;
                return activeLineup.Sum(p => p.Power) / activeLineup.Count;
            }
        }
    }
}