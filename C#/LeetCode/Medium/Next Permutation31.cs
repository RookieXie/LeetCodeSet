using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    /**
     * Implement next permutation, which rearranges numbers into the lexicographically next greater permutation of numbers.

        If such arrangement is not possible, it must rearrange it as the lowest possible order (ie, sorted in ascending order).

        The replacement must be in-place and use only constant extra memory.

        Here are some examples. Inputs are in the left-hand column and its corresponding outputs are in the right-hand column.

        1,2,3 → 1,3,2
        3,2,1 → 1,2,3
        1,1,5 → 1,5,1
     * **/
    public class Next_Permutation31
    {
        /// <summary>
        /// 思路： 题目无法理解 为解决问题
        /// </summary>
        /// <param name="nums"></param>
        public void NextPermutation(int[] nums)
        {
            int t = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                        t++;
                    }
                }
                if (i == nums.Length - 2 && t==0)
                {
                    int temp = nums[i];
                    nums[i] = nums[nums.Length - 1];
                    nums[nums.Length - 1] = temp;
                }
            }
        }
    }
}
