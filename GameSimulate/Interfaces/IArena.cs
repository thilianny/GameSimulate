namespace GameSimulate.Interfaces
{
    public interface IArena<T> where T : ISport
    {
        string Name { get; }
        string Country { get; }
        int Capacity { get; }
    }
}