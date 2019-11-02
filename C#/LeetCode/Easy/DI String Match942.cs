using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /**
     * Given a string S that only contains "I" (increase) or "D" (decrease), let N = S.length.

        Return any permutation A of [0, 1, ..., N] such that for all i = 0, ..., N-1:

        If S[i] == "I", then A[i] < A[i+1]
        If S[i] == "D", then A[i] > A[i+1]
 

        Example 1:

        Input: "IDID"
        Output: [0,4,1,3,2]
        Example 2:

        Input: "III"
        Output: [0,1,2,3]
        Example 3:

        Input: "DDI"
        Output: [3,2,0,1]
 

        Note:

        1 <= S.length <= 10000
        S only contains characters "I" or "D".
     * **/
    public class DI_String_Match942
    {
        /// <summary>
        /// 思路：循环， I 取最小值  D 取最大值
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public int[] DiStringMatch(string S)
        {
            int N = S.Length;
            int[] A = new int[N+1];
            int L = 0;
            int R = N;
            for (int i = 0; i < N; i++)
            {
                if (S[i] == 'I')
                {
                    A[i] = L;
                    L++;
                }
                else
                {
                    A[i] = R;
                    R--;
                }
            }
            A[N] = R;
            return A;
        }
    }
}
