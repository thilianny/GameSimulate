namespace GameSimulate.Interfaces
{
    public interface IParticipant
    {
        int Id { get; }
        string Title { get; }
        int Power { get;}

        void Move(); // event like football/hockey attack, ski moving and so on
    }
}