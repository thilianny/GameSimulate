namespace GameSimulate.Interfaces
{
    internal interface ITeamGame : ISportEvent
    {
        IParticipant Home { get; }
        IParticipant Away { get; }
    }
}