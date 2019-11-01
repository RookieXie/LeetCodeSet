using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    /**
     * We have a two dimensional matrix A where each value is 0 or 1.

        A move consists of choosing any row or column, and toggling each value in that row or column: changing all 0s to 1s, and all 1s to 0s.

        After making any number of moves, every row of this matrix is interpreted as a binary number, and the score of the matrix is the sum of these numbers.

        Return the highest possible score.

 

        Example 1:

        Input: [[0,0,1,1],[1,0,1,0],[1,1,0,0]]
        Output: 39
        Explanation:
        Toggled to [[1,1,1,1],[1,0,0,1],[1,1,1,1]].
        0b1111 + 0b1001 + 0b1111 = 15 + 9 + 15 = 39
 

        Note:

        1 <= A.length <= 20
        1 <= A[0].length <= 20
        A[i][j] is 0 or 1.
     * **/
    public class ScoreAfterFlippingMatrix861
    {
        /// <summary>
        /// 思路 第一列保证为1 ，从第二列开始，如果1的数量大于0的数量，不变，否则改变
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int MatrixScore(int[][] A)
        {
            int M = A.Length;
            int N = A[0].Length;
            int[] T = new int[N - 1];
            for (int j = 0; j < N - 1; j++)
            {
                T[j] = 0;
            }
            //第一列保证为1，不为1 改变这一行
            for (int i = 0; i < M; i++)
            {
                if (A[i][0] == 0)
                {
                    A[i][0] = 1;
                    for (int j = 1; j < N; j++)
                    {
                        A[i][j] = A[i][j] ^ 1;
                    }
                }
            }
            //统计第二列开始1 的数量
            for (int i = 0; i < M; i++)
            {
                for (int j = 1; j < N; j++)
                {
                    T[j - 1] = A[i][j] == 1 ? T[j - 1] + 1 : T[j - 1];
                }
            }
            //如果这列1的数量比行数的一半小或者等于,改变这一列
            for (int i = 0; i < M; i++)
            {
                for (int j = 1; j < N; j++)
                {
                    if (T[j - 1] <= M / 2)
                    {
                        A[i][j] = A[i][j] ^ 1;
                    }
                }
            }
            //获取十进制数字
            int res = 0;
            for (int i = 0; i < M; i++)
            {
                int value = 1;
                for (int j = N-1; j >=0; j--)
                {
                    res+=A[i][j] * value;
                    value *= 2;
                }
            }
            return res;
        }
    }
}
