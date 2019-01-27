namespace GameSimulate.Interfaces
{
    public interface IParticipant
    {
        int Id { get; }
        string Name { get; }
        int Power { get;}

        void Move(); // event like football/hockey attack, ski moving and so on
    }
}