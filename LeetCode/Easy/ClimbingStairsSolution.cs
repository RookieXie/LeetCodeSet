using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class ClimbingStairsSolution
    {
        public int ClimbStairs(int n)
        {
            int a = 1, b = 1;
            while (n > 0)
            {
                n--;
                b = a + b;
                a = b - a;
            }
            return a;
        }
    }
}
