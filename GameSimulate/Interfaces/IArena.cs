namespace GameSimulate.Interfaces
{
    public interface IArena<T> where T : ISportsman
    {
        string Name { get; }
        string Country { get; }
        int Capacity { get; }
    }
}