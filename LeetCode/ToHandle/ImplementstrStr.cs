using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ImplementstrStr
    {
        public int StrStr(string haystack, string needle)
        {
            if(haystack.Length < needle.Length)
            {
                return -1;
            }
            if (haystack.Length == 0 && needle.Length == 0)
            {
                return 0;
            }
            else if(needle.Length == 0)
            {
                return 0;
            }           
            int k = -1;
            int res = 0;
            int m = 0;
            for (int i = 0; i < needle.Length; i++)
            {
                if (i != 0 && k == -1)//判断有字母一个都不对应
                {
                    return -1;
                }
                for (int j = m; j < haystack.Length; j++)
                {
                    
                    if (needle[i] == haystack[j])
                    {
                        if (k == -1)
                        {
                            k = j;//记录第一个对应
                            m = j+1;//记录母字符下一个对比的开始位置
                            res++;//记录对应数量
                        }
                        else
                        {
                            m = j+1;//记录母字符下一个对比的开始位置
                            res++;//记录对应数量
                        }
                        break;//开始下一个字母比较
                    }
                    else 
                    {
                        if (k != -1)//中途有对应不上
                        {
                            j = k;//开始母字符位置调整
                            m = k + 1;//开始母字符位置调整
                            k = -1;
                            i = 0;//重新开始对比
                            res = 0;
                        }
                        
                    }
                }
            }
            if(res== needle.Length && k != -1)
            {
                return k;
            }
            else
            {
                return -1;
            }
        }
    }
}
