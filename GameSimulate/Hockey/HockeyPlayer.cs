using GameSimulate.Interfaces;

namespace GameSimulate.Hockey
{
    public class HockeyPlayer : ISportsman
    {
        public HockeyPlayer(int id, string name, int power)
        {
            Id = id;
            Name = name;
            Power = power;
        }

        public int Id { get; }
        public string Name { get; }
        public int Power { get; }
        
        public void Move()
        {
            throw new System.NotImplementedException();
        }
    }
}