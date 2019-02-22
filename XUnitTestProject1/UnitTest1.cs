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
        [Fact]
        public void AddBinaryTest()
        {
            string a = "1";
            string b = "111";
            string res = new AddBinarySolution().AddBinary(a,b);
            string lower = "1000";
            Assert.Equal(res, lower);
        }
        [Fact]
        public void SqrtTest()
        {
            int a = 4; 
          
            int res = new SqrtSolution().MySqrt(a);
            int lower = 2147483647;
            Assert.Equal(res, lower);
        }
        [Fact]
        public void ClimbStairsTest()
        {
            int a = 3;

            int res = new ClimbingStairsSolution().ClimbStairs(a);
            int lower = 3;
            Assert.Equal(res, lower);
        }
        
    }
}
