using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// Balanced strings are those who have equal quantity of 'L' and 'R' characters.
    /// Given a balanced string s split it in the maximum amount of balanced strings.
    /// Return the maximum amount of splitted balanced strings.
    /// </summary>
    public class SplitAStringInBalancedStrings1221
    {
        /// <summary>
        /// 遍历  遇到R  r++ 遇到L l++ ，if r == l t++ 同时 r l =0
        /// </summary>
        /// <param name="s"></param>
        /// <returns>2019-10-14</returns>
        public int BalancedStringSplit(string s)
        {
            int t = 0;
            int r = 0;
            int l = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'R')
                {
                    r ++;
                }
                if (s[i] == 'L')
                {
                    l ++;
                }
                if (r == l)
                {
                    t++;
                    r = 0;
                    l = 0;
                }
            }
            return t;
        }
    }
}
