using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    /**
     * Given two integers representing the numerator and denominator of a fraction, return the fraction in string format.

    If the fractional part is repeating, enclose the repeating part in parentheses.

    Example 1:

    Input: numerator = 1, denominator = 2
    Output: "0.5"
    Example 2:

    Input: numerator = 2, denominator = 1
    Output: "2"
    Example 3:

    Input: numerator = 2, denominator = 3
    Output: "0.(6)"**/
    public class Fraction_to_Recurring_Decimal166
    {
        /// <summary>
        /// 先算整数部分，余数大于0,加小数点，循环对余数处理（如果余数一样表明进入重复状态）
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public string FractionToDecimal(int numerator, int denominator)
        {
            long n = numerator;
            long d = denominator;
            HashSet<long> vs = new HashSet<long>();
            StringBuilder sb = new StringBuilder();
            if ((n < 0 && d > 0) || (d < 0 && n > 0)) sb.Append("-");  //判断是否有负数
            n = Math.Abs(n);
            d = Math.Abs(d);
            sb.Append(n / d);
           
            n = (n % d) * 10;
            if (n > 0) sb.Append(".");
            Dictionary<long, int> dic = new Dictionary<long, int>();
            int i = 0;
            int length = 0;
            StringBuilder sb2 = new StringBuilder();
            while (n != 0)
            {
                long pre = n / d;
                sb2.Append(pre);
                if (dic.ContainsKey(n))
                {
                    length=i-dic[n];
                    i = dic[n];
                    n = 0;
                }
                else
                {
                    dic.Add(n,i);
                    i++;
                }
                n = (n % d) * 10;

            }
            if (length > 0)
            {
                var res = $"{sb2.ToString().Substring(0, i)}({sb2.ToString().Substring(i, length)})";
                sb.Append(res);
            }
            else
            {
                sb.Append(sb2);
            }
            
            return sb.ToString();
        }
    }
}
