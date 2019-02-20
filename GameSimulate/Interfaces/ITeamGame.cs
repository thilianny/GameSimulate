namespace GameSimulate.Interfaces
{
    public interface ITeamGame<T> : ISportEvent
     where T : ISportsman 
    {
        ITeam<T> Home { get; }
        ITeam<T> Away { get; }
    }
}