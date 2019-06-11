using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.Football
{
    public class LiveFootballPlayer : LivePlayer
    {
        public LiveFootballPlayer(Player player) : base(player)
        {
            
        }

        public int Shots { get; } = 0;
        public int ShotsOnGoal { get; } = 0;
        public int Goals { get; } = 0;
        public int Assists { get; } = 0;
    }
}