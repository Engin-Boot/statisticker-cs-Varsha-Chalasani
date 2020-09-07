using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class Stats
    {
        public double Average { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }

        public Stats()
        {
            this.Average = Double.NaN;
            this.Min = Double.NaN;
            this.Max = Double.NaN;
        }

        public double average(List<double> numbers)
        {
            double sum = 0.0;
            int numberCount = 0;
            foreach(double number in numbers)
            {
                if (!Double.IsNaN(number))
                {
                    sum += number;
                    numberCount++;
                }
            }
            this.Average = sum / numberCount;
            return this.Average;
        }

        public double max(List<double> numbers)
        {
            this.Max = numbers[0];
            for(int i = 1; i < numbers.Count; i++)
            {
                if (!Double.IsNaN(numbers[i]))
                {
                    this.Max = Math.Max(this.Max, numbers[i]);
                }
            }
            return this.Max;
        }
        public double min(List<double> numbers)
        {
            this.Min = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (!Double.IsNaN(numbers[i]))
                {
                    this.Min = Math.Min(this.Min, numbers[i]);
                }
            }
            return this.Min;
        }
    }
}