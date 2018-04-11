using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class LengthofLastWord
    {
        public int LengthOfLastWord(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            string[] strs = s.Split(' ');
            int i = strs.Length - 1;
            while (i > 0&&strs[i] == "")
            {
                i--;
            }
            return strs[i].Length;
        }
    }
}
