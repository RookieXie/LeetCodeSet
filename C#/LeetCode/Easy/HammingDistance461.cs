using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /**
     * The Hamming distance between two integers is the number of positions at which the corresponding bits are different.

        Given two integers x and y, calculate the Hamming distance.

        Note:
        0 ≤ x, y < 231.

        Example:

        Input: x = 1, y = 4

        Output: 2

        Explanation:
        1   (0 0 0 1)
        4   (0 1 0 0)
               ↑   ↑

        The above arrows point to positions where the corresponding bits are different.
     * **/
    public class HammingDistance461
    {
        /// <summary>
        /// 2取模得出最低位数 比对
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int HammingDistance(int x, int y)
        {
            int hd = 0;
            while(x>0 || y > 0)
            {
                if (x % 2 != y % 2)
                {
                    hd++;
                }
                x /= 2;
                y /= 2;
            }
            return hd;
        }
    }
}
