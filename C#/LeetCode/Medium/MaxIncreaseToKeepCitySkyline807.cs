using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    public class MaxIncreaseToKeepCitySkyline807
    {
        /// <summary>
        /// 要求 二维数组从四面看的形状不变，可以在原来基础上加多少块
        /// 1.算出横向最高  2.算出纵向最高  3 交叉取最低的值，然后跟原来相减得可以增加的数量
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            int res = 0;
            int[] horizonHigh = new int[grid[0].Length];
            int[] portrailHigh = new int[grid.Length];
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (portrailHigh.Length == 0 || portrailHigh[j] < grid[i][j])
                    {
                        portrailHigh[j] = grid[i][j];
                    }
                    if (horizonHigh.Length == 0 || horizonHigh[i] < grid[i][j])
                    {
                        horizonHigh[i] = grid[i][j];
                    }
                }
            }
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    int min = horizonHigh[i] > portrailHigh[j]? portrailHigh[j]: horizonHigh[i];

                    res += (min - grid[i][j]);
                }
            }
            return res;
        }
    }
}
