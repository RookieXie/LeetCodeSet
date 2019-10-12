using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class RemoveElementC
    {
        public int RemoveElement(int[] nums, int val)
        {
            int length = nums.Length;
            if (length == 0) return 0;
            int k = 0;
            int m = length-1;
            for (int i = length - 1; i >= 0; i--)
            {
                if (nums[i] == val)
                {
                    if (m != i)
                    {
                        var temp = nums[m];
                        nums[m] = nums[i];
                        nums[i] = temp;
                    }
                    m--;
                    k++;
                }
            }

            return nums.Length - k;
        }
    }
}
