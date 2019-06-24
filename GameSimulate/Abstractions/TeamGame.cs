using System;
using System.Linq;
using GameSimulate.Interfaces;

namespace GameSimulate.Abstractions
{
    public abstract class TeamGame : Game
    {
        protected TeamGame(LiveTeam home, LiveTeam away, DateTime? date = null) : base(date)
        {
            Home = home;
            Away = away;
        }

        public LiveTeam Home { get; }
        public LiveTeam Away { get; }
        
        public ITeamSport Sport { get; protected set; }

        public override void Simulate()
        {
            if (!Home.Lineup.Any() || !Away.Lineup.Any())
                PowerSimulate();
            else
                RosterSimulate();
        }

        protected abstract void RosterSimulate();
        protected abstract void PowerSimulate();
    }
}