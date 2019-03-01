namespace GameSimulate.Interfaces
{
    public interface ITeamGame<T> : ISportEvent<T>
     where T : ISport
    {
        ITeam<T> Home { get; }
        ITeam<T> Away { get; }
    }
}