using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class CountandSay
    {
        public string CountAndSay(int n)
        {
            if (n == 1) return "1";
            string str = CountAndSay(n - 1);
            int count = 0;
            string res = "";
            char temp = str[0];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == temp)
                {
                    count++;
                }
                else
                {
                    res = res + count + temp;
                    temp = str[i];
                    i--;
                    count = 0;
                }
            }

            res = res + count + temp;
          
            return res;
        }
    }
}
