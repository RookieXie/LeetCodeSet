using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class LongestPalindromicSubstring
    {
        /// <summary>
        /// 思路：从两边开始往中间比较(需要多循环一次）
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        //public string LongestPalindrome(string s)
        //{
        //    string res = "";
        //    if (s.Length <= 1) return s;
        //    int t = 0;
        //    int l = 1;
        //    for (int j = 0; j < s.Length; j++)
        //    {
        //        int m = 0;
        //        int len = s.Length;
        //        for (int i = j+1; i < len; i++)
        //        {
        //            if (s[i] == s[j])
        //            {

        //                int mid = (i - j) / 2;
        //                if (mid >= 1)
        //                {
        //                    m += 2;
        //                    for (int k = 1; k <=mid; k++)
        //                    {
        //                        if (s[i - k] == s[j +k])
        //                        {
        //                            if (i - k == j + k)
        //                            {
        //                                m++;
        //                            }
        //                            else
        //                            {
        //                                m += 2;
        //                            }
        //                        }
        //                        else
        //                        {
        //                            k = mid + 1;
        //                            m = 0;
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    m += 2;
        //                }
        //                if (m >= l)
        //                {
        //                    t = j;
        //                    l = m;
        //                }
        //                m = 0;

        //            }
        //            else
        //            {
        //                if (m >= l)
        //                {
        //                    t = j;
        //                    l = m;
        //                }
        //                m = 0;
        //            }
        //        }

        //    }
        //    res= s.Substring(t, l);
        //    return res;
        //}

        
        //思路:从中间开始往两边比较
        public string LongestPalindrome(string s)
        {
            string res = "";
            if (s.Length <= 1) return s;
            int t = 0;
            int l = 1;
            for (int j = 0; j < s.Length-1; j++)
            {
                int m = 0;
                int k = j;
                //单
                for (int i = k; k<s.Length && i>=0 ; i--,k++)
                {
                    if (s[i] == s[k])
                    {
                        if (i == k)
                        {
                            m++;
                        }
                        else
                        {
                            m += 2;
                        }
                    }
                    else
                    {
                        
                        break;
                    }
                }
                if (m >= l)
                {
                    l = m;
                    t =j- m/2;
                }

                //考虑出现 字符连续的问题或者是双的问题
                m = 0;
                k = j+1;
                for (int i = j; k < s.Length && i >= 0; i--, k++)
                {
                    if (s[i] == s[k])
                    {
                        if (i == k)
                        {
                            m++;
                        }
                        else
                        {
                            m += 2;
                        }
                    }
                    else
                    {

                        break;
                    }
                }
                if (m >= l)
                {
                    l = m;
                    t = j-m/2+1;
                }
            }
            res = s.Substring(t, l);
            return res;
        }
    }
}
