using System;
using Xunit;
using Statistics;
using System.Collections.Generic;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            (var average, var min, var max) = statsComputer.CalculateStatistics(new List<float>() { 1.5f, 8.9f, 3.2f, 4.5f });
            float epsilon = 0.001F;
            Assert.True(Math.Abs(average - 4.525) <= epsilon);
            Assert.True(Math.Abs(max - 8.9) <= epsilon);
            Assert.True(Math.Abs(min - 1.5) <= epsilon);
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            (var average, var min, var max) = statsComputer.CalculateStatistics(
                new List<float>{});
            Assert.True(Double.IsNaN(average));
            Assert.True(Double.IsNaN(min));
            Assert.True(Double.IsNaN(max));
            //All fields of computedStats (average, max, min) must be
            //Double.NaN (not-a-number), as described in
            //https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
        }
    }
}
