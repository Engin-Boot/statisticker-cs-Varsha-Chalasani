using System;
using Xunit;
using Statistics;
using System.Collections.Generic;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsComputedStatsForAListOfNumbers()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(new List<double>() { 1.5f, 8.9f, 3.2f, 4.5f });
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.Average - 4.525) <= epsilon);
            Assert.True(Math.Abs(computedStats.Max - 8.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.Min - 1.5) <= epsilon);
        }
        [Fact]
        public void ReportsAllNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(new List<double>{});
            Assert.True(Double.IsNaN(computedStats.Average));
            Assert.True(Double.IsNaN(computedStats.Min));
            Assert.True(Double.IsNaN(computedStats.Max));
            //All fields of computedStats (average, max, min) must be
            //Double.NaN (not-a-number), as described in
            //https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
        }

        [Fact]
        public void ReportsComputedStatsForListOfNumbersHavingFewNaNValues()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(new List<double> {3.7f, double.NaN, 7.0f,double.NaN, 10.6f, 4.5f });
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.Average - 6.45) <= epsilon);
            Assert.True(Math.Abs(computedStats.Max - 10.6) <= epsilon);
            Assert.True(Math.Abs(computedStats.Min - 3.7) <= epsilon);
        }

    }
}
