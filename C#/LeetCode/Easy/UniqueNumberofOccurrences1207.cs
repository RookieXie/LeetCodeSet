using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// Given an array of integers arr, write a function that returns true if and only if the number of occurrences of each value in the array is unique.
    /// </summary>
    public class UniqueNumberofOccurrences1207
    {
        /// <summary>
        /// 1 统计每个数字出现的次数
        /// 2 对比次数
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                {
                    dic[arr[i]] = dic[arr[i]] + 1;
                }
                else
                {
                    dic.Add(arr[i], 1);
                }
            }
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            bool res = true;
            foreach (var item in dic)
            {
                if (pairs.ContainsKey(item.Value))
                {
                    res = false;
                    break;
                }
                else
                {
                    pairs.Add(item.Value, 1);
                }
            }
            return res;
        }
    }
}
