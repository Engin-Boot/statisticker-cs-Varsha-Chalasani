using System;
using Xunit;
using Statistics;
using System.Collections.Generic;
using static Statistics.Stats;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsComputedStatsForAListOfNumbers()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(new List<double>() { 1.5, 8.9, 3.2, 4.5 });
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
            var computedStats = statsComputer.CalculateStatistics(new List<double> {3.7, double.NaN, 7.0,double.NaN, 10.6, 4.5 });
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.Average - 6.45) <= epsilon);
            Assert.True(Math.Abs(computedStats.Max - 10.6) <= epsilon);
            Assert.True(Math.Abs(computedStats.Min - 3.7) <= epsilon);
        }
        [Fact]
        public void ReportsAllNaNForAllNaNInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(new List<double> {double.NaN, double.NaN});
            Assert.True(Double.IsNaN(computedStats.Average));
            Assert.True(Double.IsNaN(computedStats.Min));
            Assert.True(Double.IsNaN(computedStats.Max));
            //All fields of computedStats (average, max, min) must be
            //Double.NaN (not-a-number), as described in
            //https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
        }

        [Fact]

        public void IgnoresNaNValuesIfListHasNaN()
        {
            var statsComputer = new StatsComputer();
            var returnedList = statsComputer.CalculateStatistics(new List<double> { 3.7, double.NaN, 7.0, double.NaN, 10.6, 4.5 });
            Assert.True(statsComputer.numbers.Count == 6);
        }
    }
}
