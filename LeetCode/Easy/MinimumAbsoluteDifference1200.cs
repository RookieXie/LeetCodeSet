using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// Given an array of distinct integers arr, find all pairs of elements with the minimum absolute difference of any two elements. 
    /// Return a list of pairs in ascending order(with respect to pairs), each pair[a, b] follows
    /// a, b are from arr
    /// a<b
    /// b - a equals to the minimum absolute difference of any two elements in arr
    /// </summary>
    public class MinimumAbsoluteDifference1200
    {
        /// <summary>
        /// 先排序 默认从小到大 
        /// 再由于是distinct integers arr，直接后一位减前一位即可
        /// 有最小值 清空 重新插入；同为最小值 继续插入
        /// 
        /// 一开始使用双循环导致内存溢出
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            List<IList<int>> res = new List<IList<int>>();
            Array.Sort(arr);
            int min = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int value = arr[i + 1] - arr[i];
                if (min == 0 || value < min)
                {
                    min = value;
                    res.Clear();
                    res.Add(new List<int> { arr[i], arr[i+1] });
                }else if (value == min)
                {
                    res.Add(new List<int> { arr[i], arr[i + 1] });
                }
            }
            return res;
        }
    }
}
