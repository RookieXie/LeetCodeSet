using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /**
     * Given an array of integers A sorted in non-decreasing order, return an array of the squares of each number, also in sorted non-decreasing order.

 

        Example 1:

        Input: [-4,-1,0,3,10]
        Output: [0,1,9,16,100]
        Example 2:

        Input: [-7,-3,2,3,11]
        Output: [4,9,9,49,121]
 

        Note:

        1 <= A.length <= 10000
        -10000 <= A[i] <= 10000
        A is sorted in non-decreasing order.
     * **/
    public class SquaresofaSortedArray977
    {
        /// <summary>
        /// 先统计 负数 和正数的个数，从第一个正数和最后一个负数比对，小的插入新数组，小的一方的个数减1
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int[] SortedSquares(int[] A)
        {
            int[] B = new int[A.Length];
            int minus = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] < 0)
                {
                    minus++;
                }

            }
            int positive = A.Length - minus;
            int l = 0;
            while (minus > 0 || positive > 0)
            {
                if (minus == 0)
                {
                    B[l] = A[A.Length - positive] * A[A.Length - positive];
                    positive--;
                }
                else if (positive == 0)
                {
                    B[l] = A[minus - 1] * A[minus - 1];
                    minus--;
                }
                else
                {
                    if (A[minus - 1] * A[minus - 1] >= A[A.Length - positive] * A[A.Length - positive])
                    {
                        B[l] = A[A.Length - positive] * A[A.Length - positive];

                        positive--;
                    }
                    else
                    {
                        B[l] = A[minus - 1] * A[minus - 1];
                        minus--;
                    }
                }
                l++;
            }
            return B;
        }
    }
}
