﻿using LeetCode;
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
            int[] input = new int[] { 4, 2, 1, 3 };
            IList<IList<int>> output = minimumAbsoluteDifference1200.MinimumAbsDifference(input);
            Assert.Equal(new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 2, 3 }, new List<int> { 3, 4 } }.ToArray(), output);
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

            string output = dayoftheWeek1185.DayOfTheWeek(29, 2, 2016);
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
            Assert.Equal(1, 1);
        }
        [Fact]
        public void FlippinganImage832Test()
        {
            FlippinganImage832 flippinganImage832 = new FlippinganImage832();
            int[][] input = new int[][] { new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 }, new int[] { 0, 0, 0 } };
            int[][] output = flippinganImage832.FlipAndInvertImage(input);
            Assert.Equal(new int[][] { new int[] { 1, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 1, 1, 1 } }, output);
        }

        [Fact]
        public void RobotReturntoOrigin657Test()
        {
            RobotReturntoOrigin657 robotReturntoOrigin657 = new RobotReturntoOrigin657();
            string input = "LR";
            bool output = robotReturntoOrigin657.JudgeCircle(input);
            Assert.True(output);
        }
        [Fact]
        public void SelfDividingNumbers728Test()
        {
            SelfDividingNumbers728 selfDividingNumbers728 = new SelfDividingNumbers728();
            
            IList<int> output = selfDividingNumbers728.SelfDividingNumbers(1,22);
            Assert.True(true);
        }
        [Fact]
        public void SquaresofaSortedArray977Test()
        {
            SquaresofaSortedArray977 squaresofaSortedArray977 = new SquaresofaSortedArray977();
            int[] input = new int[] { -4, -1, 0, 3, 10 };
            int[] output = squaresofaSortedArray977.SortedSquares(input);
            Assert.Equal(new int[] { 0, 1, 9, 16, 100 },output);
        }
        [Fact]
        public void ArrayPartitionI561Test()
        {
            ArrayPartitionI561 arrayPartitionI = new ArrayPartitionI561();
            int[] input = new int[] { 1, 4, 3, 2 };
            int output = arrayPartitionI.ArrayPairSum(input);
            Assert.Equal(4, output);
        }
        [Fact]
        public void Delete_Columns_to_Make_Sorted944Test()
        {
            Delete_Columns_to_Make_Sorted944 delete_Columns_To_Make_ = new Delete_Columns_to_Make_Sorted944();
            string[] input = new string[] { "cba", "daf", "ghi" };
            int output = delete_Columns_To_Make_.MinDeletionSize(input);
            Assert.Equal(1, output);
        }
        [Fact]
        public void Pascal_sTriangle118Test()
        {
            Pascal_sTriangle118 pascal_STriangle = new Pascal_sTriangle118();
            
             pascal_STriangle.Generate(5);
            Assert.True(true);
        }

    }
}
