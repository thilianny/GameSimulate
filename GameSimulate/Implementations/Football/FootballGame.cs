using System;
using GameSimulate.Abstractions;

namespace GameSimulate.Implementations.Football
{
    public sealed class FootballGame : TeamGame
    {
        internal FootballGame(LiveFootballTeam home, LiveFootballTeam away, DateTime? date = null) : base(home,
            away, date)
        {
        }

        protected override void RosterSimulate()
        {
            Console.WriteLine(
                $"Simulated football game between {Home.Name} ({Home.Power}) and {Away.Name} ({Away.Power}). Used rosters");
        }

        protected override void PowerSimulate()
        {
            Console.WriteLine(
                $"Simulated football game between {Home.Name} ({Home._power}) and {Away.Name} ({Away._power}). Used only powers");
        }
    }
}