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
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {

                }
            }
            return 1;
        }
    }
}
