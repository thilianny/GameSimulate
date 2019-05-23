namespace GameSimulate.Interfaces
{
    public interface ITeamGame : IGame
    {
        ITeam Home { get; }
        ITeam Away { get; }
    }
}