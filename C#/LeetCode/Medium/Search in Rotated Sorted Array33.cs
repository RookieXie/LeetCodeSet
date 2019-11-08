using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    /**
     * Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.

    (i.e., [0,1,2,4,5,6,7] might become [4,5,6,7,0,1,2]).

    You are given a target value to search. If found in the array return its index, otherwise return -1.

    You may assume no duplicate exists in the array.

    Your algorithm's runtime complexity must be in the order of O(log n).

    Example 1:

    Input: nums = [4,5,6,7,0,1,2], target = 0
    Output: 4
    Example 2:

    Input: nums = [4,5,6,7,0,1,2], target = 3
    Output: -1
     * **/
    public class Search_in_Rotated_Sorted_Array33
    {
        /// <summary>
        /// 思路：
        /// 1.从头尾开始 i=0，n=nums.Length-1,判断是否等于target，相等 退出循环 返回对应的i或者n
        /// 2.如果 num[i]<target i++; 否则判断 nums[n] < target不存在目标值 退出循环 返回-1，否则 n--;
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Search(int[] nums, int target)
        {
            int res = -1;
            int i = 0;
            int n = nums.Length - 1;
            while (n>=i)
            {
                if (nums[i] == target)
                {
                    res = i;
                    break;
                }
                else if (nums[n] == target)
                {
                    res = n;
                    break;
                }
                else if (nums[i] < target)
                {
                    i++;
                }
                else
                {
                    if (nums[n] < target)
                    {
                        break;
                    }
                    else
                    {
                        n--;
                    }
                }
            }
            return res;
        }
    }
}
