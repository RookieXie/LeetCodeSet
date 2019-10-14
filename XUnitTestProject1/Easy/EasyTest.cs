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
            string input= "RRLRRLRLLLRL";
            int output = splitAStringInBalancedStrings1221.BalancedStringSplit(input);
            Assert.Equal(2, output);
        }
    }
}
