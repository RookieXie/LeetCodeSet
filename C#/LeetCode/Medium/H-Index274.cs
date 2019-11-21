using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    /**
     * Given an array of citations (each citation is a non-negative integer) of a researcher, write a function to compute the researcher's h-index.

    According to the definition of h-index on Wikipedia: "A scientist has index h if h of his/her N papers have at least h citations each, and the other N − h papers have no more than h citations each."

    Example:

    Input: citations = [3,0,6,1,5]
    Output: 3 
    Explanation: [3,0,6,1,5] means the researcher has 5 papers in total and each of them had 
                 received 3, 0, 6, 1, 5 citations respectively. 
                 Since the researcher has 3 papers with at least 3 citations each and the remaining 
                 two with no more than 3 citations each, her h-index is 3.
    Note: If there are several possible values for h, the maximum one is taken as the h-index.
     * **/
    public class H_Index274
    {
        /// <summary>
        /// 排序之后 循环 O(n^2)
        /// </summary>
        /// <param name="citations"></param>
        /// <returns></returns>
        public int HIndex(int[] citations)
        {
            int length = citations.Length;
            int max = 0;
            for (int i = 0; i <= length; i++)
            {
                int least = 0;
                int nomore = 0;
                for (int j = 0; j < length; j++)
                {
                    if (citations[j] >= i)
                        least++;
                    else
                        nomore--;
                }
                if (least >= i && nomore < i)
                {
                    max = i > max ? i : max;
                }
            }
            return max;
        }
        /// <summary>
        /// 思路 排序
        /// </summary>
        /// <param name="citations"></param>
        /// <returns></returns>
        public int HIndex2(int[] citations)
        {
            Array.Sort(citations);
            int len = citations.Length;
            for (int i = 0; i < len; i++)
            {
                if (citations[i] >= len - i) return len - i;

            }
            return 0;
        }
    }
}
