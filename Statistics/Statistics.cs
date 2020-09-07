using System;
using System.Collections.Generic;
using System.Linq;
using static Statistics.Stats;

namespace Statistics
{
    public class StatsComputer
    {
        public List<double> numbers;
        public Stats CalculateStatistics(List<double> numbers)
        {
            //Implement statistics here
            this.numbers = numbers;
            Stats computedStats = new Stats();
            if (numbers.Count == 0)
            {
                return computedStats;
            }
            computedStats.Average = computedStats.average(numbers);
            computedStats.Min = computedStats.min(numbers);
            computedStats.Max = computedStats.max(numbers);
            return computedStats;
        }
    }
}
