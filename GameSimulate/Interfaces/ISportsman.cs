namespace GameSimulate.Interfaces
{
    public interface ISportsman<T> : IParticipant where T : ISport
    {
        int Id { get; }
        // different fields for single sportsman
    }
}