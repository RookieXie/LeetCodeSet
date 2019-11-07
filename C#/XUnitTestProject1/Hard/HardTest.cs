using LeetCode.Hard;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject1.Hard
{
    public class HardTest
    {
        [Fact]
        public void Median_of_Two_Sorted_Arrays4Test()
        {
            Median_of_Two_Sorted_Arrays4 median_Of_Two_Sorted_ = new Median_of_Two_Sorted_Arrays4();
            int[] num1 = new int[] { 1,2 };
            int[] num2 = new int[] { 3,4 };
            double output = median_Of_Two_Sorted_.FindMedianSortedArrays(num1, num2);
            Assert.Equal(2.5, output);
        }
    }
}
