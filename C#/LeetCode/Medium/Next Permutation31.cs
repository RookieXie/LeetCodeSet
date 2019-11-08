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
        /// 1.Find the highest index i such that s[i] < s[i+1]. If no such index exists, the permutation is the last permutation.
        /// 2.Find the highest index j > i such that s[j] > s[i]. Such a j must exist, since i+1 is such an index.
        /// 3.Swap s[i] with s[j].
        /// 4.Reverse the order of all of the elements after index i till the last element
        /// </summary>
        /// <param name="nums"></param>
        public void NextPermutation(int[] nums)
        {
            int n = nums.Length, k, l;
            for (k = n - 2; k >= 0; k--)
            {
                if (nums[k] < nums[k + 1])
                {
                    break;
                }
            }
            if (k < 0)
            {
                Array.Reverse(nums);
            }
            else
            {
                for (l = n - 1; l > k; l--)
                {
                    if (nums[l] > nums[k])
                    {
                        break;
                    }
                }
                int temp = nums[k];
                nums[k] = nums[l];
                nums[l] = temp;
                Array.Reverse(nums, k+1, nums.Length-k-1);
            }
        }
    }
}
