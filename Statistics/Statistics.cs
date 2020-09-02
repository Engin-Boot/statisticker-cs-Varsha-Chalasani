using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    { 
        public Stats CalculateStatistics(List<float> numbers)
        {
            //Implement statistics here
            Stats computedStats = new Stats();
            if (numbers.Count == 0)
            {
                computedStats.Average = Double.NaN;
                computedStats.Min = Double.NaN;
                computedStats.Max = Double.NaN;
                return computedStats;
            }
            computedStats.Average = numbers.Average();
            computedStats.Min = numbers.Min();
            computedStats.Max = numbers.Max();

            return computedStats;
        }
    }
}
