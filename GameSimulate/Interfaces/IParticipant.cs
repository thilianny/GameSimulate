namespace GameSimulate.Interfaces
{
    public interface IParticipant
    {
        string Name { get; }
        int Power { get;}

        void Move(); // event like football/hockey attack, ski moving and so on
    }
}