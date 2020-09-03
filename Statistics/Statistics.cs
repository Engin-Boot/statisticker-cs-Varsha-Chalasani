using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    { 
        public Stats CalculateStatistics(List<double> numbers)
        {
            //Implement statistics here
            IgnoreNaNValues(numbers);
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

        public static List<double> IgnoreNaNValues(List<double> numbers)
        {
            numbers.RemoveAll(item => Double.IsNaN(item));

            return numbers;
        }
    }
}
