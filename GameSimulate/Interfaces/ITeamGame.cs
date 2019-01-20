namespace GameSimulate.Interfaces
{
    internal interface IOpponentsGame : ISportEvent
    {
        IParticipant Home { get; set; }
        IParticipant Away { get; set; }
    }
}