using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class IntegertoRoman
    {
        public string IntToRoman(int num)
        {
            string[] ch1 = new string[]{ "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] ch2 = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ch3 = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] ch4 = new string[] { "", "M", "MM", "MMM" }; 
            StringBuilder roman = new StringBuilder(); ;
            roman.Append(ch4[num / 1000 % 10]);
            roman.Append(ch3[num / 100 % 10]);
            roman.Append(ch2[num / 10 % 10]);
            roman.Append(ch1[num % 10]);

            return roman.ToString();
        }
    }
}
