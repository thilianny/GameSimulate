using System;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.Hockey
{

    public class LiveHockeyPlayer : LivePlayer
    {
        public LiveHockeyPlayer(Player player) : base(player)
        {
        }

        public int Shots { get; } = 0;
        public int ShotsOnGoal { get; } = 0;
        public int Goals { get; } = 0;
        public int Assists { get; } = 0;
        public int PlusMinus { get; } = 0;

        private TimeSpan _timeOnIce = new TimeSpan(0, 9, 15);
        public string TimeOnIce => $"{_timeOnIce.Minutes:00}:{_timeOnIce.Seconds:00}";
    }

}