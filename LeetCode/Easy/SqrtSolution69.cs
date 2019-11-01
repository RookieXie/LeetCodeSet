using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class SqrtSolution69
    {
        /// <summary>
        /// 69. Sqrt(x)
        /// Implement int sqrt(int x).
        /// Compute and return the square root of x, where x is guaranteed to be a non-negative integer.
        /// Since the return type is an integer, the decimal digits are truncated and only the integer part of the result is returned.
        /// Example 1:
        /// Input: 4
        /// Output: 2
        /// 
        /// Example 2:
        /// Input: 8
        ///  Output: 2
        ///   Explanation: The square root of 8 is 2.82842..., and since the decimal part is truncated, 2 is returned.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int MySqrt(int x)
        {
            int i = 0;
            int res = 0;
            long t = 0;
            while (i >= 0)
            {
                res = i;
                t = i * i;
                if (t == x)
                {
                    i = -1;
                   
                }
                else if (t > x)
                {
                    res = res - 1;
                    i = -1;
                    
                }
                else if (t < 0)
                {
                    res = res - 1;
                    i = -2;
                }else
                {
                    i++;
                }
            }
            return res;
        }
    }
}
