using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class ToLowerCaseClass709
    {
        public string ToLowerCase(string str)
        {
            char[] lowerChar = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                char lower = str[i];
                if (str[i] >= 65 && str[i] <= 90)
                {
                    lower = (char)(str[i] + 32);
                }
                lowerChar[i] = lower;
            }
            return new string(lowerChar);
            
        }
    }
}
