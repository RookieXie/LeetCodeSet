using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /**
     * Let's call an array A a mountain if the following properties hold:

    A.length >= 3
    There exists some 0 < i < A.length - 1 such that A[0] < A[1] < ... A[i-1] < A[i] > A[i+1] > ... > A[A.length - 1]
    Given an array that is definitely a mountain, return any i such that A[0] < A[1] < ... A[i-1] < A[i] > A[i+1] > ... > A[A.length - 1].

    Example 1:

    Input: [0,1,0]
    Output: 1
    Example 2:

    Input: [0,2,1,0]
    Output: 1
    Note:

    3 <= A.length <= 10000
    0 <= A[i] <= 10^6
    A is a mountain, as defined above.
     * **/
    public class Peak_Index_in_a_Mountain_Array852
    {
        /// <summary>
        /// 思路  遍历 发现有小于前一个的值返回
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int PeakIndexInMountainArray(int[] A)
        {
            int i = 1;
            int max = A[1];
            for (int j = 2; j < A.Length; j++)
            {
                if (A[j] < max)
                {
                    break;
                }
                else
                {
                    i = j;
                    max = A[j];
                }
            }
            return i;
        }
    }
}
