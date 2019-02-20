using GameSimulate.Enums;
using GameSimulate.Interfaces;

namespace GameSimulate
{
    public class Weather : ICondition<Condition>
    {
        public Weather(int windPower, Condition condition, int temperature)
        {
            WindPower = windPower;
            Condition = condition;
            Temperature = temperature;
        }

        public Condition Condition { get; }
        public int Temperature { get; }
        public int WindPower { get; }
    }
}