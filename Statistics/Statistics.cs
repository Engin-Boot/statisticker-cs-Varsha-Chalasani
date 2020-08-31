using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public (double, float, float) CalculateStatistics(List<float> numbers) {
            //Implement statistics here
            double average = numbers.Average();
            float min = Enumerable.Min(numbers);
            float max = Enumerable.Max(numbers);

            return (average, min, max);
        }
    }
}
