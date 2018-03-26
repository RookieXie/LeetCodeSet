using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            string temp = "";
            string res = "";
            for (int j = 0; j < s.Length; j++)
            {
                int m = 0;
                int len = s.Length;
                int leni = s.Length;
                for (int i = j; i < leni; i++)
                {
                    for (int k = len - 1; k >= 0; k--)
                    {
                        if (s[i] == s[k])
                        {
                            if (i == k)
                            {
                                m++;
                            }
                            else
                            {
                                m+=2;
                            }
                            
                            len = k;
                            leni = k;
                            break;
                        }
                        else
                        {
                            if (m > 0)
                            {
                                i++;
                            }
                            len = s.Length;
                            m = 0;
                        }
                    }
                }
                temp = s.Substring(j, m);
                if (temp.Length > res.Length)
                {
                    res = temp;
                }
            }
           
            return res ;
        }
    }
}
