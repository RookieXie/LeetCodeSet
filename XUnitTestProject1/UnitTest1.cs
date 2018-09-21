using LeetCode;
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
    }
}
