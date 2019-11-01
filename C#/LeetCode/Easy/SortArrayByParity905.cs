using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /*
     Given an array A of non-negative integers, return an array consisting of all the even elements of A, followed by all the odd elements of A.

You may return any answer array that satisfies this condition.

 
         */
    public class SortArrayByParity905
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int[] SortArrayByParity(int[] A)
        {
            int[] B = new int[A.Length];
            int r = 0;
            int l = A.Length - 1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    B[r] = A[i];
                    r++;
                }
                else
                {
                    B[l] = A[i];
                    l--;
                }
            }
            return B;
        }
    }
}
