﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class AddBinarySolution
    {
        public string AddBinary(string a, string b)
        {
            int alen = a.Length-1;
            int blen = b.Length-1;
            int maxlen = a.Length >= b.Length ? a.Length : b.Length;         
            string res = "";
            int k = 0;
            for (int i = maxlen - 1; i >= 0; i--)
            {
                if (blen < 0)
                {
                    if (alen >= 0)
                    {
                        int t = Convert.ToInt32(a[alen].ToString()) + k;
                        if (t < 2)
                        {
                            k = 0;
                            res = t + res;
                        }
                        else
                        {
                            k = 1;
                            res = 0 + res;
                            i = i == 0 ? i + 1 : i;
                        }
                        alen--;
                    }
                    else
                    {
                        res = k + res;
                    }

                }
                else if (alen < 0)
                {
                    if (blen >= 0)
                    {
                        int t = Convert.ToInt32(b[blen].ToString()) + k;
                        if (t < 2)
                        {
                            k = 0;
                            res = t + res;
                        }
                        else
                        {
                            k = 1;
                            res = 0 + res;
                            i = i == 0 ? i + 1 : i;
                        }
                        blen--;
                    }
                    else
                    {
                        res = k + res;
                    }
                }
                else
                {
                    int t = Convert.ToInt32(a[alen].ToString()) + Convert.ToInt32(b[blen].ToString()) +k;
                    if (t <2)
                    {
                        k = 0;
                        res = t + res;
                       
                    }
                    else if(t==2)
                    {
                        k = 1;
                        res = 0 + res;
                        i = i == 0 ? i + 1 : i;
                    }
                    else
                    {
                        k = 1;
                        res = 1 + res;
                        i = i == 0 ? i + 1 : i;
                    }
                    alen--;
                    blen--;
                }
               
            }
            return res;
        }        
    }
}
