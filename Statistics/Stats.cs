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
    }
}