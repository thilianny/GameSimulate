namespace GameSimulate.Interfaces
{
    public interface ICondition<out T> where T : System.Enum
    {
        T Condition { get; }
        int Temperature { get; }
    }
}