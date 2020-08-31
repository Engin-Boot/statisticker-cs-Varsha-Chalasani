using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class Stats
    {
        public double average;
        public double min;
        public double max;

        public Stats(double average, double min, double max)
        {
            this.average = average;
            this.min = min;
            this.max = max;
        }
    }
}

