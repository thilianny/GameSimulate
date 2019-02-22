namespace GameSimulate.Interfaces
{
    public interface IConditionable<T> where T : System.Enum
    {
        T Conditions { get; set; }
        int Temperature { get; set; }
    }
}