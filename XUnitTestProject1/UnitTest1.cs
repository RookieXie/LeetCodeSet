using LeetCode;
using LeetCode.Easy;
using LeetCode.Medium;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void NumJewelsInStonesTest()
        {
            var S = "abc";
            var J = "aaakfkdfsdjj";
            int res = new JewelsAndStones().NumJewelsInStones(S, J);
            int resmy = 3;
            Assert.Equal(res, resmy);
        }
        [Fact]
        public void MaxIncreaseKeepingSkylineTest()
        {
            int[][] grid ={

new int[]{3, 0, 8, 4},

new int[] {2, 4, 5, 7},

new int[] { 9, 2, 6, 3 },

new int[] { 0, 3, 1, 0 }

};
            int res = new MaxIncreaseToKeepCitySkyline().MaxIncreaseKeepingSkyline(grid);
            int resmy = 35;
            Assert.Equal(res, resmy);
        }
        [Fact]
        public void ToLowerCaseTest()
        {
            string upoer = "Hello";
            string res = new ToLowerCaseClass().ToLowerCase(upoer);
            string lower = "hello";
            Assert.Equal(res, lower);
        }
    }
}
