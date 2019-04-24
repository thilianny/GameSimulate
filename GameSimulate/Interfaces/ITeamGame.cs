namespace GameSimulate.Interfaces
{
    public interface ITeamGame : IGame
    {
        ITeam Home { get; set; }
        ITeam Away { get; set; }
    }
}