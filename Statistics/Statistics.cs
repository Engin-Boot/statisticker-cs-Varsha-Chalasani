using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            //Implement statistics here
            if (numbers.Count == 0)
            {
                Stats statistics = new Stats(Double.NaN, Double.NaN, Double.NaN);
                return statistics;
            }
            double average = numbers.Average();
            double min = Enumerable.Min(numbers);
            double max = Enumerable.Max(numbers);
            Stats statistics = new Stats(average, min, max);

            return statistics;
        }
    }
}
