using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject1.Easy
{
    public class EasyTest
    {
        [Fact]
        public void BalancedStringSplitTest()
        {
            SplitAStringInBalancedStrings1221 splitAStringInBalancedStrings1221 = new SplitAStringInBalancedStrings1221();
            string input = "RRLRRLRLLLRL";
            int output = splitAStringInBalancedStrings1221.BalancedStringSplit(input);
            Assert.Equal(2, output);
        }
        [Fact]
        public void UniqueNumberofOccurrences1207Test()
        {
            UniqueNumberofOccurrences1207 uniqueNumberofOccurrences1207 = new UniqueNumberofOccurrences1207();
            int[] input = new int[] { 1, 2, 2, 1, 1, 3 };
            bool output = uniqueNumberofOccurrences1207.UniqueOccurrences(input);
            Assert.True(output);
        }
        [Fact]
        public void MinimumAbsoluteDifference1200Test()
        {
            MinimumAbsoluteDifference1200 minimumAbsoluteDifference1200 = new MinimumAbsoluteDifference1200();
            int[] input = new int[] { 4, 2, 1, 3};
            IList<IList<int>> output = minimumAbsoluteDifference1200.MinimumAbsDifference(input);
            Assert.Equal(new List<List<int>> { new List<int> { 1,2 }, new List<int> { 2,3 }, new List<int> { 3,4} }.ToArray(),output);
        }
        [Fact]
        public void MaximumNumberofBalloons1189Test()
        {
            MaximumNumberofBalloons1189 maximumNumberofBalloons1189 = new MaximumNumberofBalloons1189();
            string input = "nlaebolko";
            int output = maximumNumberofBalloons1189.MaxNumberOfBalloons(input);
            Assert.Equal(1, output);
        }
        [Fact]
        public void DayoftheWeek1185Test()
        {
            DayoftheWeek1185 dayoftheWeek1185 = new DayoftheWeek1185();
           
            string output = dayoftheWeek1185.DayOfTheWeek(29,2,2016);
            Assert.Equal("Monday", output);
        }
    }
}
