using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public (double, double, double) CalculateStatistics(List<float> numbers) {
            //Implement statistics here
            double average, min, max;
            if (numbers.Count == 0)
            {
                average = Double.NaN;
                min = Double.NaN;
                max = Double.NaN;
                return (average, min, max);
            }
            average = numbers.Average();
            min = Enumerable.Min(numbers);
            max = Enumerable.Max(numbers);

            return (average, min, max);
        }
    }
}
