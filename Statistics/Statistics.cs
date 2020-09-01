using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public struct Stats
    {
        public double average;
        public double min;
        public double max;
    };

    public class StatsComputer
    { 
        public Stats CalculateStatistics(List<float> numbers)
        {
            //Implement statistics here
            Stats computedStats;
            if (numbers.Count == 0)
            {
                computedStats.average = Double.NaN;
                computedStats.min = Double.NaN;
                computedStats.max = Double.NaN;
                return computedStats;
            }
            computedStats.average = numbers.Average();
            computedStats.min = numbers.Min();
            computedStats.max = numbers.Max();

            return computedStats;
        }
    }
}
