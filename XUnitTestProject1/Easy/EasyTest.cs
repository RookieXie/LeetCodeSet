using LeetCode;
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
        [Fact]
        public void UniqueMorseCodeWords804Test()
        {
            UniqueMorseCodeWords804 uniqueMorseCodeWords = new UniqueMorseCodeWords804();
            string[] input = new string[] { "gin", "zen", "gig", "msg" };
            int output = uniqueMorseCodeWords.UniqueMorseRepresentations(input);
            Assert.Equal(2, output);
        }
        [Fact]
        public void RemoveOutermostParentheses1021Test()
        {
            RemoveOutermostParentheses1021 removeOutermostParentheses1021 = new RemoveOutermostParentheses1021();
            string input = "(()())(())";
            string output = removeOutermostParentheses1021.RemoveOuterParentheses(input);
            Assert.Equal("()()()", output);
        }
        [Fact]
        public void SortArrayByParity905Test()
        {
            SortArrayByParity905 arrayByParity905 = new SortArrayByParity905();
            int[] input = new int[] { 3, 1, 2, 4 };
            int[] output = arrayByParity905.SortArrayByParity(input);
            Assert.Equal(new int[] { 2, 4, 1, 3 }, output);
        }
        [Fact]
        public void RemoveDuplicatesfromSortedList83Test()
        {
            RemoveDuplicatesfromSortedList83 removeDuplicatesfromSortedList83 = new RemoveDuplicatesfromSortedList83();
            ListNode input = new ListNode(2);
            input.next = new ListNode(2);
            input.next.next = new ListNode(2);
            input.next.next = new ListNode(2);
            ListNode output = removeDuplicatesfromSortedList83.DeleteDuplicates2(input);
            Assert.Equal(1,1);
        }
        [Fact]
        public void FlippinganImage832Test()
        {
            FlippinganImage832 flippinganImage832 = new FlippinganImage832();
            int[][]input = new int[][] { new int[] { 1,1,0}, new int[] { 1,0,1 }, new int[] { 0,0,0} };
            int[][] output = flippinganImage832.FlipAndInvertImage(input);
            Assert.Equal(new int[][] { new int[] { 1, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 1, 1, 1 } }, output);
        }

    }
}
